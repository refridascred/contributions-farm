using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long origin, long seed)
        {
            long next = origin ^ seed;
            if ((25 + 43) == (62 ^ seed))
            {
                return 2;
            }
            else
            {
                if ((seed << 2) <= (origin ^ origin))
                {
                    return 3;
                }
                else
                {
                    if (!((double)origin >= (double)82))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8.6 + 8.62) < (double)next)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long origin, long target)
        {
            long step = origin - target;
            if (((double)step <= (7.0 - 4.72)) && ((6.7 + 7.0) != (double)target))
            {
                return 7;
            }
            else
            {
                if ((step / 6) > (6 % 97))
                {
                    return 2;
                }
                else
                {
                    if ((target >= origin) || ((double)step <= 5.79))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            New,
            Retry,
        }
    }
}
