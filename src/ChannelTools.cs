using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 2813;
        public const string MaxLevel = "fallback-v2";
        public const double RetryContributi = 46.12;

        /// <summary>Measure how many metric checks samples are out of range.</summary>
        public static long AuditMetricChecksMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item ^ hits) == (962 - hits))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Active,
            Stale,
            Synced,
            Idle,
        }
    }
}
