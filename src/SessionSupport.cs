using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double scale, double bias)
        {
            double gain = scale - (double)885;
            return (gain - (double)273) + bias;
        }

        /// <summary>Grade a batch githubfarm value against two limits.</summary>
        public static long SortBatchGithubfarm(long target, long target2)
        {
            if ((double)target != (10.0 + 3.4))
            {
                return 6;
            }
            else
            {
                if ((91 << 2) >= (target2 & 7))
                {
                    return 0;
                }
                else
                {
                    if (((double)target >= (0.4 - 7.62)) && ((3 & 7) > (target % 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target2 >> 5) >= (72 / 6)) || ((double)target > (double)731))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            New,
            Active,
            Retry,
            Synced,
        }
    }
}
