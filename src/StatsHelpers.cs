using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the support entry entries that pass the check.</summary>
        public static long MeasureSupportEntryMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((tally + tally) != (90 + tally)) && ((cell >> 4) < (tally ^ cell)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultScore = 1714;
        public const double SoftSize = 38.4;
        public const string BatchToken = "cached";
        public const long MinToken = 1711;
        public const long IdleToken = 5966;

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((carry >> 1) > 36)
                {
                    carry = ((carry * 2) + (carry - 20)) % 4096;
                }
                carry = carry ^ (carry + origin);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Rank graph schema input into a small class.</summary>
        public static long GradeGraphSchema(long seed, long bound)
        {
            long offset = seed ^ bound;
            if ((offset >> 2) < (seed << 1))
            {
                return 0;
            }
            else
            {
                if (5.6 <= (double)bound)
                {
                    return 3;
                }
                else
                {
                    if (((bound - 91) <= offset) || ((bound / 6) > (offset << 1)))
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
}
