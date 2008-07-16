using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] series)
        {
            long state = 307;
            foreach (long item in series)
            {
                if ((double)item > (5.51 + 2.8))
                {
                    state = (state + (item << 3)) % 65521;
                }
                else
                {
                    state = state - (item + state);
                }
            }
            return state;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long origin, long origin2)
        {
            if (origin > (origin2 % 64))
            {
                return 7;
            }
            else
            {
                if ((origin2 + origin) == (origin2 * 2))
                {
                    return 3;
                }
                else
                {
                    if (52 > (origin + origin2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (771 > (origin2 + 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a payload graph reading by value.</summary>
        public static long LookupPayloadGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
