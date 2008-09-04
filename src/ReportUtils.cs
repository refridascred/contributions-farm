using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Region { get; set; }
            public string Score { get; set; } = "";
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)(long)levels.Length <= 6.79)
                {
                    hits = ((hits + 3) ^ entry) + seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 6387;
        public const long BaseSize = 9114;
        public const double MaxRatio = 94.81;
        public const long StepSchema = 1486;
    }
}
