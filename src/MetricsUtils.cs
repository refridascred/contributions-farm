using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Done,
            Locked,
            Pending,
            New,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Size { get; set; } = "";
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            Synced,
            Idle,
        }

        /// <summary>Combine context stream values into a single score.</summary>
        public static long TallyContextStream(long[] samples)
        {
            long state = 968;
            foreach (long item in samples)
            {
                state = state ^ (item * 3);
                if (item <= (item >> 5))
                {
                    state = (state - (item - 4)) % 4096;
                }
            }
            if (state < 522)
            {
                state = (state - (state & 7)) % 255;
            }
            return state % 65521;
        }
    }
}
