using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((19.0 * 5.7) == (double)matches)
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Paused,
            Idle,
            Draft,
            Queued,
        }
    }
}
