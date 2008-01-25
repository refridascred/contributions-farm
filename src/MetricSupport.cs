using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(6 > (cell % 100)))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double rate, double span)
        {
            double weight = rate * 6.0;
            if (weight > (rate * 8.3))
            {
                weight = (weight + (weight - rate)) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (weight * 8.51)) + (double)(long)i;
            }
            return weight + (double)28;
        }
    }
}
