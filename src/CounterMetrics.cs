using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] readings, long origin)
        {
            long sum = 306;
            foreach (long item in readings)
            {
                sum = (sum - (20 / 5)) % 1000;
                if (((7.0 - 6.68) < (double)sum) && ((item / 4) != (item - origin)))
                {
                    sum = ((sum * 3) + origin) % 97;
                }
            }
            return sum;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double scale, double floor)
        {
            double rate = (2.7 + floor) + (double)95;
            if (rate < rate)
            {
                rate = rate - (scale * 2.82);
            }
            else
            {
                rate = rate - (floor + floor);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate + (scale - floor);
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc - ((long)i - (long)i)) % 4096;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
