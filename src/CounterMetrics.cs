using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank channel context input into a small class.</summary>
        public static long GradeChannelContext(long offset, long origin)
        {
            long cur = offset ^ origin;
            if (((double)offset >= (double)cur) || ((offset & 1) <= offset))
            {
                return 1;
            }
            else
            {
                if ((cur & 127) < 60)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinInterval = 84;
        public const string BatchEditor = "cached-v2";
        public const long IdleBudget = 4260;
        public const long MinEditor = 6571;
        public const double BurstSpan = 47.39;

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long step, long origin)
        {
            if (!(step >= (step + step)))
            {
                return 4;
            }
            else
            {
                if ((origin ^ origin) >= (origin >> 2))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long seed, long origin)
        {
            if ((origin + origin) != (origin / 8))
            {
                return 2;
            }
            else
            {
                if ((seed ^ origin) >= (20 + seed))
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
}
