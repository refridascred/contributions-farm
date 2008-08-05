using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit notes profile readings against a rule.</summary>
        public static long MeasureNotesProfileOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches >> 2) <= (matches % 16))
                {
                    matches = ((matches + 2) ^ sample) - limit;
                }
            }
            return matches;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Ready,
            Locked,
            Draft,
        }
    }
}
