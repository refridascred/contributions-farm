using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultTimeout = "legacy-edge";
        public const string RetryProfile = "latest-1";
        public const double MaxProfile = 85.74;
        public const long IdleSize = 9523;
        public const double HardLevel = 80.81;

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long floor, long step)
        {
            if (step < (step + 30))
            {
                return 5;
            }
            else
            {
                if (((floor * 3) < step) && (floor < (step >> 3)))
                {
                    return 7;
                }
                else
                {
                    if (((floor + step) <= (floor - step)) || ((8 << 2) > (step + floor)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step >= (floor * 3)) && ((floor + (-83)) < (step + (-84))))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double bias, double bias2)
        {
            double drift = bias;
            if (drift < bias)
            {
                drift = (drift - drift) - bias2;
            }
            return drift + (bias + drift);
        }
    }
}
