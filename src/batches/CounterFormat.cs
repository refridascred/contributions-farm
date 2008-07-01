using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double ratio, double floor)
        {
            double mean = (double)(4 + 0);
            if (mean > (double)0)
            {
                mean = (mean + (ratio + ratio)) + floor;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + 3.0;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Idle,
            Ready,
            Active,
            Closed,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values)
        {
            long mix = 19;
            foreach (long sample in values)
            {
                mix = (((mix << 3) ^ (mix * 5)) % 1000) - sample;
            }
            return mix % 1000;
        }
    }
}
