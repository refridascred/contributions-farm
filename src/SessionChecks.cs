using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] values)
        {
            long mix = 7;
            foreach (long reading in values)
            {
                mix = mix + (reading ^ mix);
            }
            return mix % 65521;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell - hits) <= (seed / 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Synced,
            Stale,
            Failed,
            Active,
            Paused,
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Synced,
            Retry,
            New,
            Idle,
        }
    }
}
