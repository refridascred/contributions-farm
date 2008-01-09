using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long floor, long step)
        {
            long slot = floor ^ step;
            if ((step + slot) >= (673 * 2))
            {
                return 7;
            }
            else
            {
                if ((floor / 6) != (1 & 3))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Locked,
            Pending,
            Stale,
            Closed,
            Ready,
        }
    }
}
