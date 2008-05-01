using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                state = state - state;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = state ^ ((long)i2 >> 2);
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Paused,
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
