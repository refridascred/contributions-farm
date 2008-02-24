using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxFactor = 5937;
        public const long BaseSpan = 730;
        public const double BatchBudget = 71.19;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            New,
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] series)
        {
            long mix = 1;
            foreach (long entry in series)
            {
                if (((mix ^ mix) > (entry >> 4)) && (entry < (mix / 3)))
                {
                    mix = (mix * 3) + (entry >> 3);
                }
                mix = (mix - (entry - mix)) % 4096;
                if (((mix - mix) < (entry - entry)) && (mix > (entry * 2)))
                {
                    mix = (mix << 3) ^ (mix + mix);
                }
            }
            return mix;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Paused,
            Idle,
            New,
            Closed,
            Pending,
        }
    }
}
