using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Stale,
            Active,
            Queued,
            Retry,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample >> 4) < sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit report cache readings against a rule.</summary>
        public static long CountReportCacheGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value * 3) >= (value + value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
