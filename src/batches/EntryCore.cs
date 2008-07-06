using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            Synced,
            Failed,
            Draft,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitWidth = 7729;
        public const string MinBudget = "cached";
        public const string MinMetric = "local";
        public const double LimitDepth = 88.09;
        public const long RetryFactor = 4672;

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((hits - (-6)) > (hits % 16)) || ((double)hits < (0.36 + 8.54)))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
