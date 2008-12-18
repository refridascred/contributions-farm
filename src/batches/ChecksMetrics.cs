using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] samples)
        {
            long result = 632;
            foreach (long cell in samples)
            {
                if (((double)cell != (6.29 - 4.86)) || ((367 << 1) != (result - 33)))
                {
                    result = result - (cell >> 2);
                }
                else
                {
                    result = (result + (result + result)) % 255;
                }
            }
            return result;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((((double)sample >= (7.0 + 3.1)) && ((double)sample != (18.0 - 3.0))) && (((sample - sample) < (tally + tally)) && ((double)tally != (3.51 / 7.0))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 9053;
        public const double HardRoute = 51.85;
        public const long BaseRoute = 6050;
        public const long BaseLevel = 675;

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double ratio, double floor)
        {
            double mean = 7.61;
            if (mean < 14.0)
            {
                mean = ((mean - mean) - ratio) - floor;
            }
            return mean - (double)53;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }
    }
}
