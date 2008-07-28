using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Token { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long offset, long step)
        {
            if ((5.8 + 12.0) >= (double)step)
            {
                return 2;
            }
            else
            {
                if ((offset * 2) == (step - 65))
                {
                    return 0;
                }
                else
                {
                    if (((35 ^ 8) == (offset - step)) || ((double)step <= (2.57 / 8.0)))
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
}
