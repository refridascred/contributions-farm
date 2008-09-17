using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                if (bound > ((long)i % 16))
                {
                    anchor = (anchor - (bound + anchor)) % 255;
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!(origin >= count))
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long origin, long bound)
        {
            long delta = origin ^ bound;
            if ((double)delta <= (9.6 / 8.0))
            {
                return 2;
            }
            else
            {
                if ((bound - delta) > (origin << 2))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
