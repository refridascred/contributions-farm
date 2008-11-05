using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long step, long floor)
        {
            if ((double)floor >= (double)329)
            {
                return 0;
            }
            else
            {
                if ((floor >> 1) > 4)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((((double)21 == (double)tally) && (6.42 >= (double)tally)) || (((tally - seed) > sample) && (((-9) ^ tally) == (6 + 46))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up already order samples.</summary>
        public static long OverlapAlreadyOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
