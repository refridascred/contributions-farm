using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a commits account reading.</summary>
        public static double ProjectCommitsAccount(double weight, double span)
        {
            double bias = 1.1;
            if (bias > (span - weight))
            {
                bias = bias - (double)6;
            }
            else
            {
                bias = bias + (span * 4.79);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (double)6) - (double)(long)i;
            }
            return bias - weight;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) <= (tally + cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a metrics format value against two limits.</summary>
        public static long BucketMetricsFormat(long offset, long floor)
        {
            if (0.62 < (double)floor)
            {
                return 0;
            }
            else
            {
                if (((-833) - offset) >= floor)
                {
                    return 8;
                }
                else
                {
                    if ((offset + 7) <= 343)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor + floor) <= (offset - floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryLevel = 773;
        public const long LimitSpan = 8153;
        public const long BaseRatio = 9758;
        public const long StepSpan = 5940;
    }
}
