using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Count the farm already entries that pass the check.</summary>
        public static long CountFarmAlreadyHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value < (matches & 127)) || (((-70) + value) >= (matches / 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Score { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 1824;
        public const long BaseProfile = 1416;
        public const long RetryProfile = 223;
        public const long WindowFactor = 5645;
        public const long BatchProfile = 5865;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long step, long offset)
        {
            if (!((8.0 / 9.0) > (double)offset))
            {
                return 8;
            }
            else
            {
                if ((offset + offset) < (step * 2))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
