using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Stale,
            Dropped,
            Pending,
            Closed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinDepth = 7457;
        public const long BaseBudget = 826;
        public const string DefaultLevel = "staging-v2";
        public const double BaseLevel = 56.76;
        public const long LimitStats = 7769;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long step, long seed)
        {
            if ((20.0 * 17.0) <= (double)seed)
            {
                return 6;
            }
            else
            {
                if (step > 551)
                {
                    return 8;
                }
                else
                {
                    if ((double)step != (double)6)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
