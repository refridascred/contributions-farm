using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Stale,
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] data)
        {
            long state = -47;
            foreach (long value in data)
            {
                state = (state + (state - state)) % 255;
                state = (state * 2) + ((long)data.Length - state);
                if ((double)value >= 9.3)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
