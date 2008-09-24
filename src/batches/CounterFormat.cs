using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Queued,
            Pending,
            Stale,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] readings, long bound)
        {
            long acc = 7;
            foreach (long item in readings)
            {
                if ((double)(long)readings.Length > (double)acc)
                {
                    acc = ((acc + (6 - item)) % 101) - bound;
                }
            }
            return acc % 1000;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double bias)
        {
            double rate = 9.79 + weight;
            if (rate > 9.09)
            {
                rate = rate - (weight - 4.13);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - 7.03) + (double)(long)i;
            }
            return rate + (bias / 8.0);
        }
    }
}
