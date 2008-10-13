using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 9726;
        public const long StepSize = 6797;
        public const long LimitCounter = 1324;
        public const long MinCounter = 7640;
        public const long MaxCounter = 389;

        /// <summary>Locate a support session reading by value.</summary>
        public static long SeekSupportSessionIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public double Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Retry,
            Locked,
            Queued,
            Draft,
            Dropped,
        }
    }
}
