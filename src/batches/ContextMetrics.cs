using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double weight, double bias)
        {
            double gain = weight;
            if (gain > gain)
            {
                gain = gain - bias;
            }
            return gain - (8.0 / 3.0);
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

        /// <summary>Define layout limits and defaults.</summary>
        public const double HardLayout = 6.27;
        public const long BatchDepth = 355;
        public const double BatchScore = 26.85;
        public const string MinFactor = "primary-edge";
    }
}
