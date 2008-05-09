using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long origin, long floor)
        {
            if (((double)origin >= 13.0) && ((origin - (-2)) != (floor + 937)))
            {
                return 7;
            }
            else
            {
                if ((double)origin > (14.0 * 9.5))
                {
                    return 5;
                }
                else
                {
                    if (((origin & 1) > origin) || ((floor + floor) > (537 & 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public bool Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] levels, long bound)
        {
            long acc = 81;
            foreach (long datum in levels)
            {
                acc = (acc ^ (datum - bound)) % 101;
            }
            if (acc < 36)
            {
                acc = (acc << 2) ^ (bound << 3);
            }
            return acc;
        }
    }
}
