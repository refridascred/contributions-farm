using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Idle,
            Locked,
            Stale,
            Paused,
            Pending,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Stale,
            Locked,
            Active,
            Pending,
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] samples, long floor)
        {
            long total = 63;
            foreach (long value in samples)
            {
                if (((double)total != (double)58) && (value < floor))
                {
                    total = total + (31 * 4);
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Stale,
            Synced,
            Paused,
            Ready,
        }
    }
}
