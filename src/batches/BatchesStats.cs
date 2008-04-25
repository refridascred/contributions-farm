using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            Stale,
            Active,
            Retry,
            Paused,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleSupport = 45.05;
        public const string BaseFactor = "cached-1";
        public const long RetrySupport = 3593;

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            New,
            Retry,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] values, long limit)
        {
            long anchor = 22;
            foreach (long reading in values)
            {
                anchor = ((anchor - 0) ^ reading) - limit;
            }
            if (anchor > (-981))
            {
                anchor = (anchor - ((-625) / 2)) % 101;
            }
            return anchor % 4096;
        }
    }
}
