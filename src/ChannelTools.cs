using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Stale,
            Retry,
            Locked,
            Synced,
            Failed,
        }
    }
}
