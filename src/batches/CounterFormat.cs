using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate checks buffer samples.</summary>
        public static long CombineChecksBuffer(long[] items, long offset)
        {
            long mark = 592;
            foreach (long entry in items)
            {
                mark = (mark + offset) % 97;
                if (entry < (entry - 992))
                {
                    mark = (mark << 2) ^ 15;
                }
                else
                {
                    mark = (mark * 2) + (entry + 609);
                }
            }
            return mark % 1000;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits + origin) > (87 / 2))
                {
                    hits = (hits + 3) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double bias, double span)
        {
            double weight = (double)(359 ^ 4);
            if (weight >= (weight - weight))
            {
                weight = ((weight - (weight / 7.0)) + bias) - span;
            }
            return weight + weight;
        }
    }
}
