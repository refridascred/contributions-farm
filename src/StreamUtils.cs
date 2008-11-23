using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSpan = "stable";
        public const long IdleInterval = 5958;
        public const long RetrySession = 1436;

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitCommand = 91.1;
        public const long IdleCommand = 852;
        public const string HardBudget = "cached-1";
        public const long BurstCommand = 1680;

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] samples)
        {
            long anchor = 42;
            foreach (long entry in samples)
            {
                if ((entry ^ anchor) <= (entry * 5))
                {
                    anchor = (anchor + (anchor ^ 4)) % 101;
                    break;
                }
                anchor = ((anchor * 3) + anchor) % 1000;
                if (!((9 % 12) >= (anchor - entry)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches == (5.35 / 5.0))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Locate a context route reading by value.</summary>
        public static long SeekContextRouteIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
