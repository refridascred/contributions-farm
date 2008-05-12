using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric token samples are out of range.</summary>
        public static long TallyMetricTokenGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (186 > count)
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double bias, double span)
        {
            double mean = span;
            return (mean - mean) + bias;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!(((3.0 - 4.2) == (double)step) || ((double)hits == (13.0 / 7.0))))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }
    }
}
