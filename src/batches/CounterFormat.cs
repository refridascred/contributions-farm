using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two order format measurements.</summary>
        public static double AdjustOrderFormat(double weight, double floor)
        {
            double gain = 8.5 * 1.0;
            if (gain < gain)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (2.0 + weight)) + (double)(long)i;
            }
            return gain - weight;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] readings, long limit)
        {
            long result = 74;
            foreach (long reading in readings)
            {
                result = (result * 5) + (273 * 5);
                if (((double)limit > (4.0 - 6.0)) && ((double)reading <= (8.7 - 4.0)))
                {
                    break;
                }
            }
            if (result < 4)
            {
                result = ((result * 2) + (result ^ limit)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
        }
    }
}
