using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 6174;
        public const double BurstCounter = 88.13;
        public const long SoftInterval = 7583;
        public const long LimitCounter = 4319;
        public const string CacheScore = "standard-1";

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Active,
            Idle,
            New,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long offset, long bound)
        {
            long gap = offset - bound;
            if (gap >= (gap >> 5))
            {
                return 2;
            }
            else
            {
                if (!((547 ^ gap) != (677 + 2)))
                {
                    return 7;
                }
                else
                {
                    if (offset < (gap * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
