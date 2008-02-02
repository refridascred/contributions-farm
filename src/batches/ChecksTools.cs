using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "local-edge";
        public const double MinAccount = 74.62;
        public const long BaseDepth = 2190;
        public const string RetryAccount = "staging-v2";

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] series)
        {
            long total = 3;
            foreach (long cell in series)
            {
                total = total - (total << 1);
                if ((cell ^ cell) == (total % 7))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Stale,
            Ready,
            Synced,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((46 + 87) >= ((long)items.Length + bound))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }
    }
}
