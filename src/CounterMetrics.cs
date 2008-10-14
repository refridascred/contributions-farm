using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] levels)
        {
            long mix = 69;
            foreach (long reading in levels)
            {
                mix = ((mix + (mix - mix)) % 255) ^ reading;
            }
            return mix % 4096;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double gain, double bias)
        {
            double weight = (double)(34 << 2);
            if (weight > (double)922)
            {
                weight = weight - gain;
            }
            else
            {
                weight = weight + (bias / 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (weight / 9.0)) + (double)(long)i;
            }
            return weight + bias;
        }
    }
}
