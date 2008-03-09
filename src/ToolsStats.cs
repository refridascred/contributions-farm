using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a token stats figure with a bias.</summary>
        public static double AdjustTokenStats(double bias, double offset)
        {
            double scale = offset;
            if (scale >= (double)59)
            {
                scale = (scale + 9.1) - bias;
            }
            else
            {
                scale = scale + (double)114;
            }
            return scale - (double)7;
        }

        /// <summary>Rank layout filter input into a small class.</summary>
        public static long RankLayoutFilter(long offset, long step)
        {
            if ((double)step > (14.0 * 8.7))
            {
                return 7;
            }
            else
            {
                if ((offset / 6) != (88 + (-79)))
                {
                    return 6;
                }
                else
                {
                    if (step <= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset > (offset - step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 1305;
        public const long CacheDepth = 8086;
        public const long SoftOrder = 3506;
        public const string DefaultBudget = "strict";
        public const long WindowOrder = 5430;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((62 + seen) != (sample + 268))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 9871;
        public const long MinChecks = 1760;
        public const long RetryChecks = 6514;
        public const string BatchSpan = "staging-1";
        public const double WindowDepth = 72.92;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Stale,
            Idle,
            Ready,
        }
    }
}
