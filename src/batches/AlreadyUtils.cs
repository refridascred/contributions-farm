using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long step, long limit)
        {
            long lane = step + limit;
            if (limit > (975 ^ (-1)))
            {
                return 5;
            }
            else
            {
                if ((step >> 4) >= step)
                {
                    return 6;
                }
                else
                {
                    if ((double)lane != (double)642)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double scale, double bias)
        {
            double bias2 = (bias + scale) * 9.7;
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - 17.0) + (double)(long)i;
            }
            return bias2 - scale;
        }

        /// <summary>Rank command profile input into a small class.</summary>
        public static long GradeCommandProfile(long step, long bound)
        {
            if ((bound - step) >= (0 / 8))
            {
                return 7;
            }
            else
            {
                if (((step + 67) > step) || ((double)bound < (1.4 * 4.0)))
                {
                    return 2;
                }
                else
                {
                    if ((32 < (step + step)) && ((double)bound >= (16.0 - 2.54)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepInterval = 64.33;
        public const long RetryMetric = 6444;
        public const double MinInterval = 68.52;
        public const long StepMetric = 1077;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
