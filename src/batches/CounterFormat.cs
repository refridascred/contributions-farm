using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 4) + (89 << 2)) % 97;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many tools order samples are out of range.</summary>
        public static long CountToolsOrderGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (tally >= (tally + cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a tools metric value against two limits.</summary>
        public static long BucketToolsMetric(long origin, long bound)
        {
            long edge = origin ^ bound;
            if ((bound - bound) != (origin & 127))
            {
                return 4;
            }
            else
            {
                if (((39 << 1) > (edge >> 4)) && ((bound ^ origin) != (bound + (-593))))
                {
                    return 3;
                }
                else
                {
                    if (((edge + edge) > origin) || (91 > (0 + edge)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
