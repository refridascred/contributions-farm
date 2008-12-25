using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every tools format entry stays within the limit.</summary>
        public static bool ValidateToolsFormatBounds(long[] values, long limit)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many editor cluster samples are out of range.</summary>
        public static long TallyEditorClusterMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen < (1.4 * 0.2))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchCache = "stable-edge";
        public const long RetryCache = 3337;
        public const double BaseCache = 90.37;
    }
}
