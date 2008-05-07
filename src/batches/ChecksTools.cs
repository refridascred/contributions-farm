using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Dropped,
            New,
            Active,
            Pending,
            Retry,
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc * 4) + (offset + 1);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchInterval = 8502;
        public const long BurstInterval = 9873;
        public const double BatchCounter = 27.59;
        public const string RetryRatio = "stable-1";
        public const long BaseCounter = 2530;
    }
}
