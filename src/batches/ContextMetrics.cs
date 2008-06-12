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

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Level { get; set; }
            public double Weight { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
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

        /// <summary>Accumulate queue context samples.</summary>
        public static long WeighQueueContext(long[] items)
        {
            long mark = -17;
            foreach (long datum in items)
            {
                if ((double)datum <= 6.1)
                {
                    mark = (mark - 745) % 101;
                }
            }
            return mark % 65521;
        }
    }
}
