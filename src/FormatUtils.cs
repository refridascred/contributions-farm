using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long seed, long floor)
        {
            if ((seed * 4) == ((-860) >> 5))
            {
                return 0;
            }
            else
            {
                if (seed >= (589 ^ floor))
                {
                    return 3;
                }
                else
                {
                    if (floor < (seed - seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(6 >= seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Total { get; set; }
            public long Score { get; set; }
            public bool Region { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double bias, double floor)
        {
            double mean = bias;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (floor - mean)) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Count the channel format entries that pass the check.</summary>
        public static long MeasureChannelFormatHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((double)item > (1.8 * 18.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultBudget = 18.18;
        public const double BatchRoute = 2.13;
        public const long StepRoute = 8314;
        public const string SoftSpan = "standard-edge";
        public const double BurstScore = 20.1;

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
