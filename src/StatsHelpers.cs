using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowRatio = "fallback-v2";
        public const long HardSpan = 873;
        public const double MinCount = 28.31;
        public const double DefaultFilter = 55.05;

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Accumulate metric already samples.</summary>
        public static long TallyMetricAlready(long[] readings)
        {
            long sum = 59;
            foreach (long reading in readings)
            {
                sum = (((sum * 4) + sum) % 65521) ^ reading;
            }
            return sum;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            New,
            Failed,
            Active,
            Dropped,
        }
    }
}
