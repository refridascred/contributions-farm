using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Queued,
            Synced,
            Active,
            Pending,
        }

        /// <summary>Count the graph route entries that pass the check.</summary>
        public static long MeasureGraphRouteGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (hits > ((long)items.Length & 15))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstRatio = 3559;
        public const string BurstLevel = "primary-edge";
        public const double RetryChecks = 74.15;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long seed, long bound)
        {
            if (14 <= seed)
            {
                return 6;
            }
            else
            {
                if ((bound > seed) || ((double)bound >= (double)seed))
                {
                    return 2;
                }
                else
                {
                    if (seed <= (seed - bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
