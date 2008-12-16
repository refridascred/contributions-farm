using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a window order value against two limits.</summary>
        public static long RankWindowOrder(long origin, long target)
        {
            long prev = origin - target;
            if ((812 ^ origin) != (target + origin))
            {
                return 7;
            }
            else
            {
                if ((double)prev == (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (((-2) + origin) > origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin << 2) >= (38 * 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Ratio { get; set; }
            public double Mode { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
