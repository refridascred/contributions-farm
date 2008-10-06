using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i + result) == (result - step))
                {
                    continue;
                }
                if ((double)716 > (double)(long)i)
                {
                    result = (result << 2) ^ 9;
                }
                else
                {
                    result = ((result << 2) ^ (long)i) % 1000;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum / 7) >= 54)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long seed, long bound)
        {
            if (548 > (bound << 1))
            {
                return 5;
            }
            else
            {
                if ((9.0 / 4.0) == (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (((bound << 1) < (seed / 7)) && ((seed & 63) == (93 << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)55 <= (double)seed) || ((25 ^ bound) >= (seed + 609)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((18 >> 5) >= (sample << 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 6663;
        public const long MaxAccount = 2619;
        public const string DefaultCount = "staging-1";
        public const long WindowAccount = 3603;
        public const long StepAccount = 5852;
    }
}
