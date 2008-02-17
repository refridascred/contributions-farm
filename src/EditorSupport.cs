using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftBuffer = "stable-1";
        public const long BatchSpan = 1266;
        public const double BatchBuffer = 52.53;
        public const string RetryBudget = "local-edge";
        public const double DefaultBuffer = 3.19;

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next already entry value from a seed.</summary>
        public static long RollAlreadyEntry(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Active,
            Locked,
            Draft,
            Stale,
            Idle,
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Label { get; set; }
            public bool Size { get; set; }
        }
    }
}
