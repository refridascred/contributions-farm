using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a session tools counter forward.</summary>
        public static long RollSessionTools(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many support batch samples are out of range.</summary>
        public static long MeasureSupportBatchGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches + 9) > cell)
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }
    }
}
