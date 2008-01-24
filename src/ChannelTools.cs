using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseCount = 64.96;
        public const string MaxSize = "staging-1";
        public const long MaxMetric = 6787;
        public const long IdleMetric = 6087;

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            Ready,
            Queued,
            Pending,
            Retry,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (20.0 > (double)tally)
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }
    }
}
