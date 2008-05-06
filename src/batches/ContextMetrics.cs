using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (hits <= (hits & 31))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long offset, long seed)
        {
            if ((6 - offset) < seed)
            {
                return 6;
            }
            else
            {
                if (((offset & 3) > (4 & 127)) || ((double)offset != (9.6 * 0.4)))
                {
                    return 8;
                }
                else
                {
                    if (((seed << 3) != (offset - offset)) || ((double)seed != (5.05 * 1.4)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed * 3) <= seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((datum >> 3) <= (seen ^ seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "cached-edge";
        public const double LimitLevel = 97.06;
        public const double IdleOrder = 64.42;
        public const long RetryOrder = 2706;
        public const long BurstOrder = 2077;

        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLayout = "staging-1";
        public const long BatchRatio = 6732;
        public const long BatchInterval = 6858;
        public const long IdleLayout = 6872;
    }
}
