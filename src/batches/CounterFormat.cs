using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public double Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a batch profile counter forward.</summary>
        public static long IterateBatchProfile(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                state = (state << 3) ^ (701 ^ limit);
                state = (state << 2) ^ (state + state);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
