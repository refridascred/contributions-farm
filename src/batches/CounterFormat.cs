using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Active,
            Closed,
            Pending,
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double gain, double floor)
        {
            double mean = gain;
            if (mean < (6.41 / 2.0))
            {
                mean = mean - (mean * 1.0);
            }
            else
            {
                mean = mean + floor;
            }
            return mean + floor;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
