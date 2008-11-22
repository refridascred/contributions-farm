using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Synced,
            New,
            Failed,
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((count + count) != (item << 1)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Pending,
            Closed,
            Locked,
        }
    }
}
