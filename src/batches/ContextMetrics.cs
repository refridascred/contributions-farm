using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long floor, long target)
        {
            if (((31 >> 1) <= (floor & 1)) || ((13.0 * 0.6) < (double)floor))
            {
                return 6;
            }
            else
            {
                if (((88 * 2) == (target + 6)) || ((double)target >= (0.26 - 0.8)))
                {
                    return 7;
                }
                else
                {
                    if ((71 * 4) != (target / 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor <= (floor - target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Dropped,
            New,
            Stale,
            Pending,
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double ratio, double span)
        {
            double bias = span;
            if (bias > span)
            {
                bias = (bias - bias) + ratio;
            }
            return bias - (double)686;
        }
    }
}
