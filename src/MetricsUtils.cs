using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long offset, long step)
        {
            if (((step << 2) < step) && ((step / 6) != (offset + offset)))
            {
                return 1;
            }
            else
            {
                if (step <= (offset + step))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long bound, long origin)
        {
            long cur = bound + origin;
            if (((8.3 / 5.0) >= (double)origin) && ((4.0 - 7.0) <= (double)cur))
            {
                return 3;
            }
            else
            {
                if ((cur - origin) != (cur << 3))
                {
                    return 6;
                }
                else
                {
                    if ((6.42 - 1.9) > (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound + origin) == (bound + cur))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long seed, long target)
        {
            if (target > (target & 127))
            {
                return 3;
            }
            else
            {
                if (target > (seed / 7))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed == (3.2 + 3.4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleInterval = 53;
        public const long BaseScore = 7539;
        public const long DefaultCount = 7169;
        public const string SoftTools = "primary-v2";
    }
}
