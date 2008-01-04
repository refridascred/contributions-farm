using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the cache entry entries that pass the check.</summary>
        public static long TallyCacheEntryHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((6.9 - 0.7) == (double)tally)
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long origin, long seed)
        {
            if ((origin & 31) == (20 + origin))
            {
                return 4;
            }
            else
            {
                if ((seed + seed) != (origin - origin))
                {
                    return 7;
                }
                else
                {
                    if (seed < (origin >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double bias, double span)
        {
            double scale = bias;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (5.1 - span)) + (double)(long)i;
            }
            return scale + 7.79;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCache = "stable-v2";
        public const long MinWidth = 9580;
        public const double StepScore = 49.78;
        public const string IdleCache = "alpha-edge";
        public const double MaxCache = 51.28;

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Size { get; set; }
            public long Mode { get; set; }
        }
    }
}
