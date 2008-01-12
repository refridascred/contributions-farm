using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] data, long target)
        {
            long mark = 33;
            foreach (long item in data)
            {
                if (2.8 > (double)target)
                {
                    mark = ((mark ^ ((-1) << 3)) % 1000) ^ item;
                }
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 2317;
        public const double WindowCommits = 21.88;
        public const double CacheInterval = 31.39;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 5767;
        public const long DefaultSpan = 1395;
        public const long BurstBuffer = 1448;
        public const long WindowFactor = 8700;
        public const string DefaultBuffer = "alpha-edge";
    }
}
