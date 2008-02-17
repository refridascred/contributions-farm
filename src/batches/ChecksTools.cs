using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string HardAlready = "standard-1";
        public const long IdleCount = 1599;
        public const string CacheAlready = "latest";
        public const long BatchAlready = 5952;
        public const long BaseAlready = 2938;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((double)tally < (19.0 - 1.43)) && (((double)tally <= (7.39 * 9.0)) || ((0.6 - 9.96) >= (double)tally)))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Pending,
            New,
            Done,
        }
    }
}
