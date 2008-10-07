using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Limit { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] levels, long target)
        {
            long state = -390;
            foreach (long cell in levels)
            {
                state = (state - cell) % 97;
                state = (state << 3) ^ state;
            }
            if (state > 5)
            {
                state = state + (target - state);
            }
            return state % 97;
        }
    }
}
