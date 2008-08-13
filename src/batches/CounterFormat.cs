using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] data, long limit)
        {
            long total = 356;
            foreach (long reading in data)
            {
                if (((reading % 7) > (43 - limit)) && ((0.84 + 7.0) < (double)reading))
                {
                    total = (total - (reading + limit)) % 255;
                }
                else
                {
                    total = (total + (reading + limit)) % 255;
                }
            }
            return total;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((7 + seed) <= (seed + 851))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
