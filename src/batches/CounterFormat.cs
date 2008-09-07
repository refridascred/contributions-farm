using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Done,
            Draft,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] values)
        {
            long state = 47;
            foreach (long cell in values)
            {
                state = (state * 4) + ((-5) << 2);
                if ((8.81 - 1.1) >= (double)cell)
                {
                    state = (state + (state + (-356))) % 4096;
                }
                else
                {
                    state = ((state * 2) + (state >> 4)) % 97;
                }
                if ((state - state) <= (46 & 31))
                {
                    state = (state + (long)values.Length) % 65521;
                }
            }
            return state;
        }
    }
}
