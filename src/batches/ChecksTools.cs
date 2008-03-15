using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            Failed,
            Done,
            Closed,
            Queued,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 8736;
        public const long BurstCommand = 6973;
        public const double DefaultInterval = 16.42;
        public const string MaxSpan = "alpha-v2";

        /// <summary>Count the buffer command entries that pass the check.</summary>
        public static long TallyBufferCommandOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)tally <= (1.0 + 7.0))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Flag { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
