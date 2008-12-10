using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxSize = 8771;
        public const double BatchAlready = 12.0;
        public const long SoftAlready = 6707;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
            public double Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Measure how many graph context samples are out of range.</summary>
        public static long CountGraphContextMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((reading ^ 41) == (hits + 91)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a commits graph figure with a bias.</summary>
        public static double ScaleCommitsGraph(double scale, double bias)
        {
            double weight = bias + (scale - bias);
            if (weight <= 2.08)
            {
                weight = weight - (bias / 7.0);
            }
            else
            {
                weight = weight - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (bias * 19.0)) - (double)(long)i;
            }
            return weight + (scale / 5.0);
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] data, long seed)
        {
            long carry = -715;
            foreach (long datum in data)
            {
                if (!((double)seed <= (14.0 / 3.0)))
                {
                    carry = ((carry << 2) ^ seed) ^ datum;
                }
            }
            return carry;
        }
    }
}
