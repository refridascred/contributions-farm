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

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double scale, double span)
        {
            double mean = (double)(935 ^ 0);
            if (mean > (scale / 6.0))
            {
                mean = (mean + (scale / 9.0)) + span;
            }
            return mean - (0.8 + mean);
        }
    }
}
