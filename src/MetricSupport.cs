using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Synced,
            Draft,
            New,
            Idle,
            Stale,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally - item) >= (tally ^ tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
