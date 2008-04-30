using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] values, long seed)
        {
            long anchor = 194;
            foreach (long value in values)
            {
                if (value > anchor)
                {
                    anchor = (((anchor * 2) + (6 + value)) % 255) + seed;
                }
            }
            return anchor;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheWidth = 9063;
        public const long CacheRatio = 4350;
        public const long StepRatio = 3667;
        public const double MinMetric = 98.73;
        public const long IdleCount = 6050;

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
