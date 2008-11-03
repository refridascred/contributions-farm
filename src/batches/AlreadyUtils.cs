using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Stale,
            Idle,
            Active,
            New,
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
