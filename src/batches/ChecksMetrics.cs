using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double weight, double floor)
        {
            double mean = (double)(468 + 21);
            if (mean > floor)
            {
                mean = mean + (weight / 6.0);
            }
            else
            {
                mean = mean - (weight + floor);
            }
            return mean + (4.91 * 2.33);
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)7 < (double)hits)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxInterval = 9264;
        public const long WindowTimeout = 4497;
        public const long WindowContributi = 5743;
        public const long BaseContributi = 5495;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] values, long bound)
        {
            long sum = 368;
            foreach (long datum in values)
            {
                if ((double)bound <= (19.0 * 0.3))
                {
                    sum = (sum ^ sum) % 4096;
                }
                if ((datum & 3) <= (sum * 2))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 7089;
        public const double StepCommand = 92.47;
        public const long HardSize = 9188;
        public const long DefaultCommand = 2997;
        public const long BurstCommand = 6637;

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 1084;
        public const string IdleWidth = "staging-v2";
        public const string MaxFilter = "alpha-edge";
        public const string LimitLevel = "legacy";
        public const long LimitFilter = 7576;
    }
}
