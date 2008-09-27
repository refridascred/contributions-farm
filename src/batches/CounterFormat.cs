using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double gain, double offset)
        {
            double load = (offset - gain) * 3.0;
            if (load >= 1.6)
            {
                load = load + load;
            }
            else
            {
                load = load - (gain + offset);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (gain + offset)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value + value) == (bound >> 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
