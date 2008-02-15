using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = (result << 3) ^ ((long)i2 << 2);
                    result = (result << 2) ^ result;
                }
                if ((seed & 1) <= seed)
                {
                    result = result - (795 * 2);
                    result = (result * 4) + result;
                }
                else
                {
                    result = result - seed;
                    result = ((result << 3) ^ (seed * 5)) % 255;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                if (!((state << 1) < (476 >> 4)))
                {
                    state = (state ^ (state << 1)) % 1000;
                    state = state - (step / 4);
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
