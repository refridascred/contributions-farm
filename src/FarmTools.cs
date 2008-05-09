using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a record notes counter forward.</summary>
        public static long StepRecordNotes(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = ((state << 3) ^ ((long)i2 & 7)) % 1000;
                }
                if ((double)21 <= (double)state)
                {
                    state = state ^ (limit + state);
                }
                else
                {
                    state = (state * 5) + state;
                }
                if ((double)(-27) == (double)limit)
                {
                    state = (state << 2) ^ (long)i;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseQueue = 60.69;
        public const long StepSize = 531;
        public const double SoftRatio = 76.71;

        /// <summary>Match up command context samples.</summary>
        public static long CompareCommandContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
