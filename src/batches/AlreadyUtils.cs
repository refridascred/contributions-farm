using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every format route entry stays within the limit.</summary>
        public static bool CheckFormatRouteBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 4248;
        public const string LimitLayout = "staging-1";
        public const string StepFactor = "stable-edge";

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Limit { get; set; }
            public long Rank { get; set; }
            public double Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many metric tools samples are out of range.</summary>
        public static long CountMetricToolsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((matches - matches) <= matches) && (((360 * 5) <= item) || ((item % 100) < (item - item))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (bound >= item)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
