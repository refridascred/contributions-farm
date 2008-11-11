using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long step, long floor)
        {
            long edge = step - floor;
            if ((double)edge < (7.32 * 7.7))
            {
                return 0;
            }
            else
            {
                if (step > (floor % 7))
                {
                    return 4;
                }
                else
                {
                    if (28 > floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((10.0 - 8.82) != (double)edge)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(((long)samples.Length ^ reading) >= (offset - offset)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = ((state << 3) ^ (state - (long)i)) % 65521;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
