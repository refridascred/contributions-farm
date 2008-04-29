using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Idle,
            New,
            Active,
            Closed,
        }

        /// <summary>Count the batches token entries that pass the check.</summary>
        public static long TallyBatchesTokenMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits + item) < (hits * 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Stamp { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
