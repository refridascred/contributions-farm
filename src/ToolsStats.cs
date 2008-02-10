using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long bound, long floor)
        {
            if ((floor >= (bound << 3)) || ((75 >> 4) < (floor + bound)))
            {
                return 3;
            }
            else
            {
                if ((floor & 127) < (bound + bound))
                {
                    return 8;
                }
                else
                {
                    if (!((2.61 + 14.0) < (double)bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a payload commits value against two limits.</summary>
        public static long RankPayloadCommits(long limit, long origin)
        {
            if ((origin << 3) <= (588 << 2))
            {
                return 2;
            }
            else
            {
                if (((7.0 * 0.1) >= (double)limit) || ((origin >> 3) >= (origin / 5)))
                {
                    return 0;
                }
                else
                {
                    if (!((limit % 2) < (limit ^ 86)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long seed, long target)
        {
            if ((target / 6) > (seed + seed))
            {
                return 7;
            }
            else
            {
                if ((((-8) + seed) != (seed / 6)) || ((seed + target) <= seed))
                {
                    return 8;
                }
                else
                {
                    if ((target % 5) >= seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] items, long floor)
        {
            long total = 5;
            foreach (long datum in items)
            {
                if ((total * 3) == (datum % 16))
                {
                    total = ((total ^ 16) % 4096) - floor;
                }
            }
            if (total > 14)
            {
                total = (total + total) % 4096;
            }
            return total % 97;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Synced,
            Locked,
            Draft,
        }
    }
}
