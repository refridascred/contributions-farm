using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double weight, double bias)
        {
            double drift = (double)(613 & 7);
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - bias) + (double)(long)i) - weight;
            }
            return drift + bias;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine notes metrics values into a single score.</summary>
        public static long TotalNotesMetrics(long[] readings)
        {
            long acc = 6;
            foreach (long datum in readings)
            {
                acc = (acc + (acc + acc)) ^ datum;
            }
            return acc % 4096;
        }

        /// <summary>Find the first format payload entry that matches the target.</summary>
        public static long FindFormatPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
