using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((double)item != (double)2) || (hits <= (hits * 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit entry report readings against a rule.</summary>
        public static long CountEntryReportOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((((8.79 / 4.0) < (double)step) || ((hits - step) <= step)) || !((step + reading) <= (hits / 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
