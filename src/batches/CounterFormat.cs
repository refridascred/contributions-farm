using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long floor, long seed)
        {
            if (((seed - seed) < (seed - floor)) || (((-95) & 15) < (2 ^ floor)))
            {
                return 3;
            }
            else
            {
                if ((seed % 97) == (floor + floor))
                {
                    return 6;
                }
                else
                {
                    if (!((seed * 4) <= (89 - seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed - 373) >= (floor + floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (seed >= (seed - hits))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
