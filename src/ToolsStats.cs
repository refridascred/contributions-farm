using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Synced,
            Paused,
            Failed,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double scale, double span)
        {
            double mean = (double)66 * 0.15;
            if (mean < scale)
            {
                mean = mean + span;
            }
            else
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (double)19) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheRatio = 6002;
        public const double CacheTimeout = 36.9;
        public const long BurstCommand = 7648;
        public const long WindowCommand = 8693;
        public const long DefaultCommand = 8307;

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWindow = 58.51;
        public const long SoftInterval = 1570;
        public const string SoftWindow = "alpha-1";

        /// <summary>Measure how many schema counter samples are out of range.</summary>
        public static long CountSchemaCounterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches >> 4) >= (matches - reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftContributi = "cached";
        public const double MinTimeout = 26.8;
        public const long DefaultWidth = 5022;
    }
}
