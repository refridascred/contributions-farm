using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            Failed,
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Check that every command queue entry stays within the limit.</summary>
        public static bool ValidateCommandQueueBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public double Score { get; set; }
        }
    }
}
