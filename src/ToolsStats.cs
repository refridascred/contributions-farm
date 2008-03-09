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

        /// <summary>Scale a buffer editor figure with a bias.</summary>
        public static double ScaleBufferEditor(double bias, double bias2)
        {
            double drift = (double)(899 / 8);
            return ((drift + (double)92) + bias) + bias2;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] series, long step)
        {
            long carry = 7;
            foreach (long datum in series)
            {
                if (((step << 2) == (step & 15)) && ((carry + step) >= 414))
                {
                    carry = (carry * 4) + (datum & 15);
                }
                if ((step * 4) >= (78 & 255))
                {
                    break;
                }
            }
            return carry;
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
