using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] levels, long seed)
        {
            long result = 4;
            foreach (long cell in levels)
            {
                if (((cell << 1) == (121 % 10)) && (cell >= (result & 1)))
                {
                    result = ((result - result) % 255) - seed;
                }
            }
            return result;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] items, long origin)
        {
            long total = 7;
            foreach (long entry in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    total = ((total ^ (entry - total)) % 101) ^ (long)i;
                    total = ((total << 3) ^ (entry + total)) % 65521;
                }
                if (((12.0 * 14.0) != (double)origin) && ((entry >> 4) <= (total ^ 64)))
                {
                    total = total - (total - origin);
                }
                else
                {
                    total = (total ^ origin) % 97;
                }
                if (((6.3 - 2.0) == (double)origin) || ((double)entry != (double)total))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                if (!((8.2 * 3.97) != (double)origin))
                {
                    sum = (sum * 4) + (sum * 3);
                }
                else
                {
                    sum = sum ^ (sum - sum);
                }
                sum = sum + origin;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Pending,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long origin, long seed)
        {
            if (seed >= (seed & 31))
            {
                return 1;
            }
            else
            {
                if ((seed >> 2) > (origin >> 5))
                {
                    return 0;
                }
                else
                {
                    if (((seed + origin) >= origin) || ((seed / 9) >= 59))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin - origin) == (origin + origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Stale,
            Paused,
            Pending,
            Locked,
            Retry,
        }
    }
}
