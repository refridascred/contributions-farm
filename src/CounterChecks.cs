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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)sample >= (double)tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinDepth = 57.65;
        public const double SoftGraph = 93.0;
        public const double CacheWidth = 21.49;
        public const string BurstFactor = "fallback-v2";
        public const long BaseGraph = 1821;

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Rank { get; set; }
            public string Limit { get; set; } = "";
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
