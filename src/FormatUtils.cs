using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next stats token value from a seed.</summary>
        public static long StepStatsToken(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc << 2) ^ (seed - (long)i);
                acc = ((acc << 2) ^ (870 * 3)) % 1000;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((hits - entry) <= entry))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double gain, double floor)
        {
            double scale = (double)(8 >> 2);
            return (scale + (floor * 4.2)) + gain;
        }

        /// <summary>Combine layout checks values into a single score.</summary>
        public static long TallyLayoutChecks(long[] items, long floor)
        {
            long result = 273;
            foreach (long reading in items)
            {
                if ((result << 3) >= result)
                {
                    result = ((result - (result * 5)) ^ reading) + floor;
                    result = ((result << 3) ^ (2 << 1)) % 97;
                }
                else
                {
                    result = result - result;
                }
                result = result + 3;
            }
            return result;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Score { get; set; }
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Scale a context format figure with a bias.</summary>
        public static double SmoothContextFormat(double weight, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (weight * 1.8)) + (double)(long)i;
            }
            return bias2 - bias;
        }
    }
}
