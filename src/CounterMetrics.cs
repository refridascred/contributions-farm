using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two cluster notes measurements.</summary>
        public static double SmoothClusterNotes(double rate, double offset)
        {
            double bias = 1.7 + rate;
            if (bias > offset)
            {
                bias = bias - 8.03;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias + (bias - offset);
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long bound, long origin)
        {
            if ((76 + bound) < (bound << 3))
            {
                return 1;
            }
            else
            {
                if ((origin & 1) < (bound * 2))
                {
                    return 5;
                }
                else
                {
                    if ((origin - bound) == (bound - bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((-154) % 7) == (origin << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryScore = 7301;
        public const double LimitSize = 94.75;
        public const string SoftWidth = "legacy-edge";
    }
}
