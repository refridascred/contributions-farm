using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Idle,
            Paused,
            Done,
            New,
            Active,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Weight { get; set; }
            public string Count { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long step, long floor)
        {
            long gap = step ^ floor;
            if ((double)step >= (double)gap)
            {
                return 1;
            }
            else
            {
                if ((96 << 2) < (gap & 255))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
