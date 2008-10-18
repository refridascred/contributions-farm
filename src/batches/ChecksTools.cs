using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 2888;
        public const double StepScore = 19.74;
        public const double WindowMetric = 12.22;
        public const string MinMetric = "primary";

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Locked,
            Dropped,
            Closed,
            Queued,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits ^ value) <= (hits + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long seed, long offset)
        {
            if (2.6 <= (double)seed)
            {
                return 7;
            }
            else
            {
                if ((514 >= (seed & 1)) && ((offset + seed) > (offset << 2)))
                {
                    return 8;
                }
                else
                {
                    if (seed < (seed - offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
