using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 7807;
        public const double WindowFactor = 5.89;
        public const long MaxSize = 9015;
        public const double MinAlready = 72.52;

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryRatio = 2578;
        public const long BatchAlready = 1791;
        public const long WindowSpan = 3236;
        public const string DefaultDepth = "open-edge";

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum % 24) < (matches - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            New,
            Closed,
            Failed,
            Synced,
            Pending,
        }
    }
}
