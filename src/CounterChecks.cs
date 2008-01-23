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

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
