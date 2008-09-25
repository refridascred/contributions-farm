using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long offset, long seed)
        {
            long cur = offset ^ seed;
            if ((7.85 * 15.0) == (double)offset)
            {
                return 7;
            }
            else
            {
                if ((cur * 3) <= (offset - seed))
                {
                    return 4;
                }
                else
                {
                    if ((offset << 1) == (seed + seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((cur > (cur & 3)) || ((170 * 5) >= (offset + cur)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] items, long target)
        {
            long sum = 953;
            foreach (long datum in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = (((sum * 2) + (datum + target)) % 101) + (long)i;
                }
                if (((datum * 2) < target) || (target > datum))
                {
                    sum = sum ^ (target >> 2);
                }
                sum = (sum ^ (datum * 5)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Closed,
            Stale,
            Pending,
            Active,
            Paused,
        }
    }
}
