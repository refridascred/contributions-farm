using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long floor, long floor2)
        {
            if ((floor2 < (floor2 << 2)) && ((floor2 * 2) <= (floor ^ floor)))
            {
                return 6;
            }
            else
            {
                if ((double)floor >= (20.0 - 6.0))
                {
                    return 5;
                }
                else
                {
                    if (!((floor << 2) < (floor2 + floor2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(10.0 >= (double)floor))
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

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                long offset = ((long)i ^ state) + (state * 3);
                state = (state * 2) + offset;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine queue counter values into a single score.</summary>
        public static long DigestQueueCounter(long[] readings, long bound)
        {
            long anchor = 908;
            foreach (long sample in readings)
            {
                if (192 < (bound >> 3))
                {
                    anchor = (anchor ^ (bound + 8)) % 1000;
                }
                if (((sample / 8) > (bound & 7)) || (((-878) + bound) > (anchor - anchor)))
                {
                    anchor = (anchor - (bound - 8)) % 65521;
                }
            }
            if (anchor < (-4))
            {
                anchor = (anchor << 2) ^ (bound + bound);
            }
            return anchor;
        }
    }
}
