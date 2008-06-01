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

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long target, long seed)
        {
            long delta = target + seed;
            if ((double)delta > (3.0 * 9.3))
            {
                return 5;
            }
            else
            {
                if ((4.84 - 5.0) <= (double)delta)
                {
                    return 0;
                }
                else
                {
                    if ((seed << 3) < delta)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
