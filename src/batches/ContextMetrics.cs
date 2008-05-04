using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double rate, double floor)
        {
            double bias = (double)((-5) - 51);
            if (bias < (bias / 2.0))
            {
                bias = (bias - (double)3) - floor;
            }
            return bias + (rate - bias);
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a token payload pair into a bucket.</summary>
        public static long RankTokenPayload(long bound, long floor)
        {
            if ((double)bound != (double)35)
            {
                return 7;
            }
            else
            {
                if ((floor & 15) >= (bound << 3))
                {
                    return 4;
                }
                else
                {
                    if (((81 % 2) == (bound + floor)) && ((double)bound == (5.1 * 7.77)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
