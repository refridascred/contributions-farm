using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first stats notes entry that matches the target.</summary>
        public static long LookupStatsNotesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((origin << 1) >= (score - 15))
                {
                    score = score - (score << 1);
                }
                long matches = ((long)i % 7) % 7;
                if (!((double)6 != (double)matches))
                {
                    matches = ((matches * 4) + (score + 1)) % 65521;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
