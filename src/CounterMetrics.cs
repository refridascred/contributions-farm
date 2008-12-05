using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double scale, double floor)
        {
            double weight = 13.0;
            if (weight >= (double)6)
            {
                weight = (weight + (5.62 / 3.0)) - scale;
            }
            else
            {
                weight = weight + floor;
            }
            return weight - 3.09;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (3 < (sample - step))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public bool Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] data, long floor)
        {
            long state = 5;
            foreach (long cell in data)
            {
                state = (((state ^ state) % 255) + cell) + floor;
            }
            return state;
        }
    }
}
