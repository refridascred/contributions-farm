using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the commits already series from a seed.</summary>
        public static long DeriveCommitsAlready(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix + mix) % 1000;
                mix = ((mix * 5) + (mix >> 1)) % 255;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Locked,
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchLayout = "latest-edge";
        public const long DefaultLayout = 876;
        public const long StepLevel = 3915;
    }
}
