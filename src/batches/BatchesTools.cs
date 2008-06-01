using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxRatio = 94.91;
        public const double MaxSize = 78.59;
        public const double CacheInterval = 2.22;
        public const double RetryDepth = 77.77;
        public const long DefaultGraph = 3506;

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] levels, long floor)
        {
            long anchor = 4;
            foreach (long value in levels)
            {
                anchor = ((anchor - (value / 2)) % 101) - floor;
            }
            return anchor % 1000;
        }
    }
}
