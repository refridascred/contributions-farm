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

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long seed, long offset)
        {
            long next = seed - offset;
            if (((double)offset <= (2.3 / 9.0)) || ((12.0 * 4.0) >= (double)offset))
            {
                return 0;
            }
            else
            {
                if ((12 << 1) <= offset)
                {
                    return 4;
                }
                else
                {
                    if ((8.85 - 19.0) != (double)next)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
