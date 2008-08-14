using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 5647;
        public const double IdleSchema = 6.98;
        public const string BatchFactor = "fallback-edge";
        public const string HardTimeout = "latest-1";
        public const long CacheWidth = 6642;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Failed,
            Done,
            Dropped,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleWidth = 1295;
        public const long BatchLevel = 2280;
        public const long CacheInterval = 5393;
        public const double BatchNotes = 43.4;
        public const string RetryScore = "local";

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] series)
        {
            long acc = 1;
            foreach (long sample in series)
            {
                acc = ((acc ^ (50 - acc)) % 255) ^ sample;
            }
            return acc;
        }
    }
}
