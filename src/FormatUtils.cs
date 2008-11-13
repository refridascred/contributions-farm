using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the githubfarm context entries that pass the check.</summary>
        public static long MeasureGithubfarmContextGaps(long[] series, long limit)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((-34) + value) > (hits + value))
                {
                    hits = (hits + 1) - limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Total { get; set; }
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)603 == (double)reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardScore = 5942;
        public const long CacheLayout = 8407;
        public const string BaseLayout = "open";
        public const long DefaultBudget = 6229;

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchInterval = 9295;
        public const long BurstCommand = 2302;
        public const double BurstTimeout = 94.96;
        public const string LimitCommand = "legacy-1";
        public const double WindowCommand = 29.19;
    }
}
