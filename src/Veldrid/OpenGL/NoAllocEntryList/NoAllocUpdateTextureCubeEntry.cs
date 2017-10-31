﻿namespace Veldrid.OpenGL.NoAllocEntryList
{
    internal struct NoAllocUpdateTextureCubeEntry
    {
        public readonly HandleTracked<TextureCube> TextureCube;
        public readonly HandleTrackedStagingBlock StagingBlock;
        public readonly CubeFace Face;
        public readonly uint X;
        public readonly uint Y;
        public readonly uint Width;
        public readonly uint Height;
        public readonly uint MipLevel;
        public readonly uint ArrayLayer;

        public NoAllocUpdateTextureCubeEntry(
            TextureCube textureCube,
            StagingBlock stagingBlock,
            CubeFace face,
            uint x,
            uint y,
            uint width,
            uint height,
            uint mipLevel,
            uint arrayLayer)
        {
            TextureCube = textureCube;
            StagingBlock = new HandleTrackedStagingBlock(stagingBlock);
            Face = face;
            X = x;
            Y = y;
            Width = width;
            Height = height;
            MipLevel = mipLevel;
            ArrayLayer = arrayLayer;
        }
    }
}