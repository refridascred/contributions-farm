using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] samples, long origin)
        {
            long mix = 921;
            foreach (long entry in samples)
            {
                mix = (((mix * 4) + (origin + mix)) % 97) - entry;
            }
            if (mix > 25)
            {
                mix = ((mix * 2) + (mix + mix)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Idle,
            Retry,
            Stale,
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Active,
            Done,
            Dropped,
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Synced,
            Ready,
            Paused,
            Locked,
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public long Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
