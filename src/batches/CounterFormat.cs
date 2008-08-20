using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long seed, long floor)
        {
            long cur = seed - floor;
            if ((seed + cur) <= (floor * 4))
            {
                return 6;
            }
            else
            {
                if ((cur - 2) <= (seed * 5))
                {
                    return 8;
                }
                else
                {
                    if ((17.0 - 2.0) > (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
