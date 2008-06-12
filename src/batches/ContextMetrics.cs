using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor << 3) ^ anchor) % 255;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Synced,
            New,
            Stale,
            Paused,
            Draft,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] readings)
        {
            long state = 28;
            foreach (long sample in readings)
            {
                state = (state - 57) + sample;
            }
            return state % 4096;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Idle,
            Locked,
            Draft,
            Retry,
            Stale,
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Region { get; set; }
            public long Level { get; set; }
        }
    }
}
