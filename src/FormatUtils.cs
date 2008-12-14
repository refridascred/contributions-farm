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

        /// <summary>Check that every command metrics entry stays within the limit.</summary>
        public static bool ValidateCommandMetricsRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double gain, double floor)
        {
            double scale = (double)(8 >> 2);
            return (scale + (floor * 4.2)) + gain;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long offset, long offset2)
        {
            if (((double)offset2 < (20.0 - 0.13)) || ((offset + offset2) >= offset2))
            {
                return 0;
            }
            else
            {
                if (((double)offset < (0.72 / 4.0)) && ((3.0 - 14.0) < (double)offset2))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset >= (6.9 - 3.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
