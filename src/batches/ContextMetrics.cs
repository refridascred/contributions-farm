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

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] values)
        {
            long sum = 1;
            foreach (long entry in values)
            {
                sum = (sum - (760 % 64)) + entry;
            }
            if (sum > 1)
            {
                sum = ((sum << 2) ^ sum) % 97;
            }
            return sum % 4096;
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
