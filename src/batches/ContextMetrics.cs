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

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long seed, long target)
        {
            if ((seed * 2) == (4 << 3))
            {
                return 8;
            }
            else
            {
                if (((seed / 6) < seed) && (target >= (target % 8)))
                {
                    return 4;
                }
                else
                {
                    if (!((double)seed <= (7.6 + 6.3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultPayload = 46.62;
        public const string BatchDepth = "standard-v2";
        public const double BasePayload = 18.08;
        public const double BaseCount = 54.11;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long target, long seed)
        {
            long step = target - seed;
            if ((step > (step / 6)) || (18 > (seed * 4)))
            {
                return 3;
            }
            else
            {
                if ((seed % 10) > step)
                {
                    return 1;
                }
                else
                {
                    if (!((848 + seed) <= (target ^ seed)))
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
}
