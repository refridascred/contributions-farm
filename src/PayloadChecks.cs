using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first layout command entry that matches the target.</summary>
        public static long FindLayoutCommandIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!!((entry - entry) > matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long floor, long seed)
        {
            if ((floor - seed) <= (8 - seed))
            {
                return 6;
            }
            else
            {
                if ((floor << 1) == (1 >> 5))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Done,
            Closed,
            Active,
        }

        /// <summary>Measure how many graph counter samples are out of range.</summary>
        public static long TallyGraphCounterGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((tally + (long)levels.Length) <= (tally + 210)) || ((tally + item) == (tally + 420)))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }
    }
}
