using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] readings, long bound)
        {
            long acc = 7;
            foreach (long item in readings)
            {
                if ((double)(long)readings.Length > (double)acc)
                {
                    acc = ((acc + (6 - item)) % 101) - bound;
                }
            }
            return acc % 1000;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] readings)
        {
            long mark = 42;
            foreach (long datum in readings)
            {
                if ((((long)readings.Length ^ 94) >= (datum ^ datum)) && ((3.87 + 10.0) == (double)datum))
                {
                    mark = (mark ^ (datum - 0)) % 97;
                }
                else
                {
                    mark = (mark + datum) % 4096;
                }
            }
            if (mark < (-272))
            {
                mark = mark + (400 & 31);
            }
            return mark % 4096;
        }
    }
}
