using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double bias, double offset)
        {
            double ratio = bias;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio - bias) + (double)(long)i) + offset;
            }
            return ratio + bias;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long target, long target2)
        {
            long step = target + target2;
            if (((step - 94) < step) && ((0 - target) == ((-36) - target)))
            {
                return 1;
            }
            else
            {
                if (((double)step > 1.4) || ((target2 << 3) != (target + target)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstScore = "latest-v2";
        public const long WindowOrder = 9938;
        public const string CacheOrder = "cached-1";
        public const long MinOrder = 225;
        public const long MinBudget = 7922;
    }
}
