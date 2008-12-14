using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Retry,
            Closed,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] values)
        {
            long mark = 979;
            foreach (long cell in values)
            {
                mark = mark - mark;
                if (mark > (cell >> 5))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
