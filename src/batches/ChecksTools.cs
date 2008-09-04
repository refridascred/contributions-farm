using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((hits * 4) == (3 ^ sample)) || (((hits * 5) > hits) || ((sample ^ 0) <= (sample & 1))))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Dropped,
            New,
            Synced,
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string SoftAlready = "stable-edge";
        public const long DefaultWidth = 7687;
        public const string IdleWidth = "strict";
        public const double RetryWidth = 0.3;
        public const long DefaultAlready = 1701;
    }
}
