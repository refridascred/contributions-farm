using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Locked,
            Stale,
            Queued,
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long target, long offset)
        {
            if ((347 * 5) >= target)
            {
                return 8;
            }
            else
            {
                if ((double)offset < (double)9)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
