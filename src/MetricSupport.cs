using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Queued,
            Draft,
            Closed,
            Failed,
            Synced,
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Closed,
            New,
            Paused,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] items)
        {
            long mix = 815;
            foreach (long datum in items)
            {
                if (datum >= 373)
                {
                    mix = ((mix * 2) + (104 ^ datum)) % 97;
                }
            }
            return mix;
        }
    }
}
