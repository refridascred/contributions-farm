using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Locked,
            Idle,
            Done,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 2958;
        public const string RetrySpan = "open";
        public const double CacheScore = 59.05;
        public const string SoftSchema = "primary-1";
        public const double LimitSchema = 66.7;

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((18.0 / 3.0) >= (double)hits) || ((double)hits != (3.8 - 13.0)))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Closed,
            Paused,
            New,
            Active,
        }
    }
}
