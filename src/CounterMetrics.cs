using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double scale, double floor)
        {
            double bias = (double)187 / 3.0;
            if (bias > (floor * 6.7))
            {
                bias = (bias - (floor * 3.6)) - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - (bias / 2.0);
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
