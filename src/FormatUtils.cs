using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long origin, long bound)
        {
            long bound2 = origin + bound;
            if ((origin + bound2) < bound2)
            {
                return 0;
            }
            else
            {
                if ((86 + bound) > (bound / 2))
                {
                    return 7;
                }
                else
                {
                    if ((bound2 - bound) == (origin % 97))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin >> 5) > (origin + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "strict-v2";
        public const double CacheRoute = 54.66;
        public const long StepSpan = 4898;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepTimeout = 1388;
        public const long IdleTimeout = 7274;
        public const long CacheScore = 1867;
        public const long MaxLevel = 3957;

        /// <summary>Count the payload order entries that pass the check.</summary>
        public static long CountPayloadOrderGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell + hits) >= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 3903;
        public const long BaseCount = 7404;
        public const long RetryFarm = 5257;
        public const long LimitScore = 4309;

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long step, long bound)
        {
            long prev = step + bound;
            if ((bound / 3) != (step - step))
            {
                return 3;
            }
            else
            {
                if ((bound + prev) == (bound << 1))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
