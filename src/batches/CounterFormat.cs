using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Offset { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Pending,
            Closed,
            Done,
            Ready,
        }

        /// <summary>Roll a counter already counter forward.</summary>
        public static long SeriesCounterAlready(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
