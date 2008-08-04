using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] items)
        {
            long mix = 9;
            foreach (long item in items)
            {
                if ((item * 5) > (mix << 2))
                {
                    mix = (mix ^ item) % 65521;
                    mix = (mix - (mix & 15)) % 65521;
                }
                mix = (mix ^ mix) % 1000;
            }
            return mix;
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
