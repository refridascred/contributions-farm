using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleCount = 4931;
        public const long MinChecks = 773;
        public const double BaseChecks = 6.78;
        public const long HardInterval = 1528;

        /// <summary>Project the next batches commits value.</summary>
        public static double ProjectBatchesCommits(double rate, double floor)
        {
            double drift = floor;
            if (drift <= rate)
            {
                drift = drift + (double)45;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift + rate;
        }

        /// <summary>Validate account token readings against a bound.</summary>
        public static bool ValidateAccountTokenBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Active,
            Paused,
            Closed,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((double)sample == (4.53 * 11.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double ratio, double offset)
        {
            double load = offset / 6.0;
            if (load < offset)
            {
                load = (load - offset) - ratio;
            }
            else
            {
                load = load + load;
            }
            return load + offset;
        }
    }
}
