using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] data, long target)
        {
            long total = 7;
            foreach (long entry in data)
            {
                if (target > (entry + total))
                {
                    total = (total * 3) + entry;
                    total = total + (total + total);
                    continue;
                }
                total = (total + entry) % 101;
                total = ((total << 3) ^ (entry * 5)) % 65521;
            }
            return total;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double scale, double offset)
        {
            double load = (double)(467 + 251);
            return (load - (offset * 13.0)) + scale;
        }
    }
}
