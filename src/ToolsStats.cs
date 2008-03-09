using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next metric metrics value.</summary>
        public static double AdjustMetricMetrics(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 < 3.0)
            {
                rate2 = (rate2 + rate) + offset;
            }
            else
            {
                rate2 = rate2 - (double)486;
            }
            return rate2 + rate;
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

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] levels, long bound)
        {
            long total = 5;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    total = ((total - (bound % 3)) % 1000) ^ (long)i;
                }
                total = total - reading;
            }
            return total;
        }

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
