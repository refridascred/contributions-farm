using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Active,
            Closed,
            Draft,
            Synced,
            Queued,
        }

        /// <summary>Scale a checks batch figure with a bias.</summary>
        public static double ProjectChecksBatch(double scale, double floor)
        {
            double bias = (double)(-72) * 18.0;
            if (bias >= (double)(-39))
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (floor * 4.8)) + (double)(long)i;
            }
            return bias - (scale / 3.0);
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 5205;
        public const double DefaultWidth = 93.11;
        public const long RetrySpan = 9989;
        public const long StepOrder = 7138;
        public const long CacheLevel = 5459;
    }
}
