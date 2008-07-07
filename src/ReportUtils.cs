using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 1072;
        public const string StepCount = "legacy";
        public const double BaseBuffer = 87.72;
        public const long BurstCount = 83;

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long target, long origin)
        {
            if ((origin % 3) <= (origin + origin))
            {
                return 7;
            }
            else
            {
                if ((double)target <= 17.0)
                {
                    return 1;
                }
                else
                {
                    if ((102 > (origin + origin)) || ((35 - target) <= origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((43 + 8) == (target % 10))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Done,
            Failed,
            Queued,
            Closed,
        }

        /// <summary>Blend two contributi editor measurements.</summary>
        public static double ScaleContributiEditor(double gain, double offset)
        {
            double bias = 15.0;
            if (bias < 3.59)
            {
                bias = (bias - offset) - gain;
            }
            else
            {
                bias = bias - (bias + bias);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - (12.0 + offset);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 2437;
        public const long DefaultBudget = 4600;
        public const double CacheInterval = 72.47;
    }
}
