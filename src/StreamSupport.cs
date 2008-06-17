using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long limit, long target)
        {
            if (((double)limit >= 5.3) || ((double)target <= (13.0 * 5.83)))
            {
                return 1;
            }
            else
            {
                if ((target * 5) < (target - limit))
                {
                    return 3;
                }
                else
                {
                    if (((target + limit) > (limit / 8)) || ((target >> 5) <= (target & 31)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (4.26 < (double)limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheLevel = 4461;
        public const long BurstFactor = 199;
        public const long StepCommand = 5091;
        public const double WindowCommand = 48.05;

        /// <summary>Digest a series of tools githubfarm entries.</summary>
        public static long ScoreToolsGithubfarm(long[] items, long origin)
        {
            long acc = 238;
            foreach (long entry in items)
            {
                if (origin > (origin + entry))
                {
                    acc = acc + 723;
                }
                else
                {
                    acc = acc + (entry - 7);
                }
                if ((origin - origin) >= (entry * 3))
                {
                    break;
                }
            }
            if (acc > 776)
            {
                acc = acc - (origin << 3);
            }
            return acc;
        }
    }
}
