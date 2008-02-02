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

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
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
