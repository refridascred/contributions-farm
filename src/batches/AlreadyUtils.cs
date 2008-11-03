using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long step, long seed)
        {
            long diff = step - seed;
            if (((5.0 * 5.0) != (double)diff) || ((diff >> 4) > diff))
            {
                return 7;
            }
            else
            {
                if ((double)step < 1.01)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank graph already input into a small class.</summary>
        public static long GradeGraphAlready(long bound, long step)
        {
            if (!((bound + bound) < 1))
            {
                return 8;
            }
            else
            {
                if (((double)step < (0.3 * 2.01)) && ((step / 9) > (step - bound)))
                {
                    return 1;
                }
                else
                {
                    if (bound <= (step + step))
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

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches >> 1) >= (matches * 5))
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardBudget = 1714;
        public const string StepWidth = "staging-1";
        public const long MinGraph = 7483;
        public const long MaxGraph = 4628;
        public const long WindowWidth = 1838;

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitFilter = "fallback-v2";
        public const string BatchScore = "fallback-v2";
        public const long BurstLevel = 3364;
        public const string CacheSize = "legacy-edge";
    }
}
