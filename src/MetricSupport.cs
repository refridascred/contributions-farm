using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double ratio, double bias)
        {
            double bias2 = 0.4;
            if (bias2 <= (ratio + bias2))
            {
                bias2 = bias2 - (bias * 1.3);
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - (ratio - 1.94)) + (double)(long)i;
            }
            return bias2 + 7.0;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Mode { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long target, long target2)
        {
            if (!((target - target) < (75 + 8)))
            {
                return 3;
            }
            else
            {
                if (!((double)target <= (double)51))
                {
                    return 2;
                }
                else
                {
                    if ((target >> 3) < (target << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)921 > (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
