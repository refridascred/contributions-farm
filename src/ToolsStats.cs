using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((seed * 5) <= count) && (104 < (730 - entry)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of cache order entries.</summary>
        public static long ScoreCacheOrder(long[] readings, long target)
        {
            long sum = 52;
            foreach (long item in readings)
            {
                sum = ((((sum * 4) + (sum & 7)) % 101) - item) + target;
            }
            return sum % 65521;
        }

        /// <summary>Grade a metrics entry value against two limits.</summary>
        public static long BucketMetricsEntry(long origin, long target)
        {
            if ((target >> 4) <= (origin - target))
            {
                return 0;
            }
            else
            {
                if ((origin - target) <= (origin % 16))
                {
                    return 1;
                }
                else
                {
                    if ((target % 16) < (7 >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long target, long bound)
        {
            long bound2 = target + bound;
            if (bound > (target + bound))
            {
                return 1;
            }
            else
            {
                if (((double)bound2 >= (1.0 - 1.3)) && ((double)bound < (0.96 * 14.0)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 7038;
        public const string LimitInterval = "strict";
        public const long RetryChecks = 5894;
        public const double DefaultChecks = 44.86;

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long origin, long origin2)
        {
            long gap = origin ^ origin2;
            if ((double)origin2 == (20.0 + 0.8))
            {
                return 7;
            }
            else
            {
                if (((gap % 12) <= ((-235) * 4)) && ((origin2 + origin) <= origin))
                {
                    return 5;
                }
                else
                {
                    if ((double)gap == (double)95)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
