using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Retry,
            Draft,
            Pending,
            Active,
            Stale,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long limit, long target)
        {
            if (((target & 1) != (limit - limit)) && ((target / 9) > ((-31) & 1)))
            {
                return 4;
            }
            else
            {
                if ((target * 5) == (5 % 5))
                {
                    return 3;
                }
                else
                {
                    if ((((-4) >> 2) <= (target + target)) && ((818 - target) < target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (limit > (limit + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long origin)
        {
            long score = origin;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 2) ^ (772 / 9)) % 65521;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultPayload = 46.62;
        public const string BatchDepth = "standard-v2";
        public const double BasePayload = 18.08;
        public const double BaseCount = 54.11;

        /// <summary>Grade a entry metric value against two limits.</summary>
        public static long GradeEntryMetric(long step, long origin)
        {
            long offset = step ^ origin;
            if (((double)step > (double)offset) && (step > (step - step)))
            {
                return 7;
            }
            else
            {
                if ((883 ^ origin) <= (origin << 2))
                {
                    return 2;
                }
                else
                {
                    if ((origin - origin) == (origin << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
