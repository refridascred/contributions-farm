using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                long next = carry;
                carry = (carry + (carry ^ next)) % 255;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Closed,
            Stale,
            Active,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Size { get; set; }
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
