using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the cluster profile entries that pass the check.</summary>
        public static long MeasureClusterProfileMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(7.4 <= (double)offset))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
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

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] items)
        {
            long state = -6;
            foreach (long entry in items)
            {
                state = ((state * 5) + (state << 2)) % 4096;
                state = ((state << 3) ^ (state + entry)) % 1000;
                if (state > (state - state))
                {
                    break;
                }
            }
            if (state < 679)
            {
                state = (state + state) % 101;
            }
            return state;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftContributi = "cached";
        public const double MinTimeout = 26.8;
        public const long DefaultWidth = 5022;
    }
}
