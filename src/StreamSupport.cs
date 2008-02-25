using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] data, long limit)
        {
            long mix = 72;
            foreach (long entry in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = (mix - (long)i) % 4096;
                }
                if ((double)2 == (double)entry)
                {
                    mix = (mix << 3) ^ limit;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultSize = "local-v2";
        public const double CacheWidth = 97.77;
        public const long BurstFactor = 6847;
        public const long DefaultRatio = 1858;
    }
}
