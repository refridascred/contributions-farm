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

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 60.61;
        public const long RetryQueue = 6128;
        public const string WindowDepth = "local-v2";
        public const long MaxCount = 5771;
    }
}
