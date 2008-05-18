using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Ready,
            Retry,
            Synced,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches - matches) > entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
