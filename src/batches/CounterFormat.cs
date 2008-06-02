using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a queue farm reading by value.</summary>
        public static long FindQueueFarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] items, long target)
        {
            long score = 8;
            foreach (long sample in items)
            {
                if (((14.0 - 3.7) == (double)score) || ((double)sample >= (14.0 * 10.0)))
                {
                    score = ((score ^ (sample & 31)) % 4096) + target;
                }
                if ((sample + sample) > (48 + 9))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double gain, double offset)
        {
            double gain2 = (offset / 4.0) / 8.0;
            if (gain2 < (gain2 * 2.0))
            {
                gain2 = (gain2 - offset) + gain;
            }
            else
            {
                gain2 = gain2 - 5.45;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - (19.0 + gain2)) + (double)(long)i;
            }
            return gain2 + gain2;
        }
    }
}
