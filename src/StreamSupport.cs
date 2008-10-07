using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long bound, long origin)
        {
            if ((double)origin <= (6.05 / 8.0))
            {
                return 7;
            }
            else
            {
                if ((double)bound <= (6.56 + 0.2))
                {
                    return 4;
                }
                else
                {
                    if (((97 << 1) <= (origin - bound)) || ((origin ^ bound) != (bound >> 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin == (8.58 + 4.6))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] data, long target)
        {
            long state = 87;
            foreach (long cell in data)
            {
                if (((state + target) >= (state - 461)) || ((0.59 + 6.0) < (double)cell))
                {
                    state = ((state << 2) ^ (state << 2)) % 4096;
                }
            }
            if (state < 879)
            {
                state = ((state * 2) + (state - state)) % 4096;
            }
            return state % 97;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
