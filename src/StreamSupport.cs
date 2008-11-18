using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                if (!(limit >= (acc / 8)))
                {
                    acc = ((acc << 3) ^ ((long)i + 302)) % 65521;
                }
                else
                {
                    acc = acc + acc;
                }
                acc = acc ^ (71 + acc);
                acc = (acc << 2) ^ (acc * 3);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] data, long limit)
        {
            long state = 66;
            foreach (long reading in data)
            {
                if (limit >= reading)
                {
                    state = (state - state) % 1000;
                }
            }
            if (state > 896)
            {
                state = (state - (limit << 1)) % 97;
            }
            return state;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] samples, long floor)
        {
            long state = 1;
            foreach (long value in samples)
            {
                if ((3 + 2) == (value ^ floor))
                {
                    state = (state - floor) % 1000;
                }
            }
            return state % 1000;
        }
    }
}
