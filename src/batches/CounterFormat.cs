using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Label { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
