using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long target, long origin)
        {
            long lane = target - origin;
            if (((lane & 31) == (lane - origin)) && ((9.23 * 6.0) == (double)lane))
            {
                return 5;
            }
            else
            {
                if ((target & 255) < (target / 6))
                {
                    return 7;
                }
                else
                {
                    if (182 <= target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target < (7.21 - 1.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseAccount = 56.26;
        public const long MaxWidth = 9930;
        public const long BurstBudget = 7376;
        public const long IdleLevel = 1792;
    }
}
