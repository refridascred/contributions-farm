using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many schema batches samples are out of range.</summary>
        public static long TallySchemaBatchesMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((6.5 * 7.8) <= (double)matches) || ((matches >> 3) < (cell - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double scale, double offset)
        {
            double gain = 0.8;
            for (int i = 0; i < 4; i++)
            {
                gain = (((gain + (5.95 * 3.0)) + (double)(long)i) - scale) - offset;
            }
            return gain + (double)836;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((seed + sample) == (seed & 3))
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

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double weight, double bias)
        {
            double bias2 = (bias - bias) / 4.0;
            return (bias2 - bias) + weight;
        }
    }
}
