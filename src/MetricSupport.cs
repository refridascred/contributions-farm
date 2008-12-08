using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double rate, double floor)
        {
            double weight = 7.0;
            if (weight < (weight - floor))
            {
                weight = (weight - 18.0) - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight + (double)907;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] data, long target)
        {
            long carry = 8;
            foreach (long datum in data)
            {
                carry = (((carry - carry) % 255) + datum) + target;
            }
            return carry % 4096;
        }
    }
}
