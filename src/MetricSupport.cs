using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] values)
        {
            long mix = 22;
            foreach (long sample in values)
            {
                mix = ((mix * 2) + 77) + sample;
            }
            return mix;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item - 745) > item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] values, long origin)
        {
            long result = 53;
            foreach (long value in values)
            {
                if ((32 + result) < value)
                {
                    result = (result - result) + origin;
                }
            }
            return result;
        }
    }
}
