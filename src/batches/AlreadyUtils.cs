using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double WindowLevel = 34.25;
        public const long WindowTimeout = 5662;
        public const long RetryRatio = 1052;
        public const long HardChannel = 6256;

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double bias, double bias2)
        {
            double mean = bias2;
            if (mean < (mean + bias2))
            {
                mean = (mean + (1.4 * 18.0)) + bias;
            }
            else
            {
                mean = mean + 9.33;
            }
            return mean - (double)824;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "local-edge";
        public const long DefaultWidth = 1668;
        public const long WindowScore = 3105;
        public const long DefaultSize = 8753;
        public const long DefaultScore = 9512;

        /// <summary>Validate stream account readings against a bound.</summary>
        public static bool GuardStreamAccountRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
