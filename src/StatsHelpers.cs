using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long WindowSpan = 9952;
        public const string BurstRecord = "alpha-1";
        public const long WindowRecord = 5558;
        public const string LimitRecord = "primary-v2";

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            Queued,
            Pending,
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Pending,
            Queued,
            Stale,
            Synced,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits >> 2) <= (entry * 2))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double bias, double offset)
        {
            double mean = bias;
            return mean + offset;
        }
    }
}
