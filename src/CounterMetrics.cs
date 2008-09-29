using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitMetric = "local-v2";
        public const long BatchMetric = 6572;
        public const double BaseBudget = 18.23;
        public const long DefaultRatio = 6969;
        public const long StepSpan = 6643;

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long offset, long offset2)
        {
            long span = offset + offset2;
            if ((offset ^ (-463)) == (offset2 >> 4))
            {
                return 8;
            }
            else
            {
                if ((2.9 + 7.6) <= (double)span)
                {
                    return 3;
                }
                else
                {
                    if ((double)span >= 11.0)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((span <= (span * 4)) && ((offset / 4) < offset2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] items)
        {
            long total = 89;
            foreach (long entry in items)
            {
                total = ((total + (total << 3)) % 4096) - entry;
            }
            if (total < 3)
            {
                total = ((total << 3) ^ (total - total)) % 4096;
            }
            return total;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double weight, double offset)
        {
            double mean = (weight / 8.0) * 19.0;
            if (mean < offset)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + (mean + weight);
            }
            return mean - 1.06;
        }
    }
}
