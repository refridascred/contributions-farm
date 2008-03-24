using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long step, long floor)
        {
            long next = step - floor;
            if (floor < step)
            {
                return 8;
            }
            else
            {
                if (((step ^ 94) < (step >> 3)) || ((135 << 3) < floor))
                {
                    return 2;
                }
                else
                {
                    if ((double)step < 3.0)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((next + step) <= floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Retry,
            Draft,
            Idle,
            Synced,
            New,
        }

        /// <summary>Project the next window metric value.</summary>
        public static double BlendWindowMetric(double scale, double span)
        {
            double scale2 = (double)(882 >> 1);
            return (scale2 - (span - scale2)) + scale;
        }
    }
}
