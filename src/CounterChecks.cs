using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Region { get; set; }
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Pending,
            Paused,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinDepth = 57.65;
        public const double SoftGraph = 93.0;
        public const double CacheWidth = 21.49;
        public const string BurstFactor = "fallback-v2";
        public const long BaseGraph = 1821;

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue tools entries that pass the check.</summary>
        public static long MeasureQueueToolsMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((limit % 100) < hits)
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long limit, long seed)
        {
            if ((double)limit != (double)seed)
            {
                return 8;
            }
            else
            {
                if (seed < (-154))
                {
                    return 0;
                }
                else
                {
                    if (((limit - seed) > seed) && ((2.5 * 8.71) < (double)seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
