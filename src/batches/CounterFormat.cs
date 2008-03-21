using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample > matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Total { get; set; }
            public bool Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Scale a checks farm figure with a bias.</summary>
        public static double SmoothChecksFarm(double rate, double floor)
        {
            double mean = 7.83 - (double)600;
            if (mean <= (double)5)
            {
                mean = (mean + mean) - rate;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (floor + floor);
        }
    }
}
