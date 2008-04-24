using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate metrics already samples.</summary>
        public static long DigestMetricsAlready(long[] values, long origin)
        {
            long total = 6;
            foreach (long cell in values)
            {
                if (((long)values.Length * 2) < (origin / 4))
                {
                    total = ((total << 3) ^ cell) % 65521;
                }
            }
            if (total > 55)
            {
                total = (total - origin) % 97;
            }
            return total % 97;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long offset, long offset2)
        {
            if (((double)offset2 >= (6.3 - 9.24)) || ((9.96 + 4.25) != (double)offset2))
            {
                return 2;
            }
            else
            {
                if (offset2 > (offset2 >> 1))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long floor, long floor2)
        {
            if (((floor2 ^ 864) != (floor2 - floor2)) && (floor2 >= 5))
            {
                return 2;
            }
            else
            {
                if ((floor * 2) >= (1 / 6))
                {
                    return 4;
                }
                else
                {
                    if (floor <= (floor >> 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
