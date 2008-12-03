using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Score { get; set; }
            public bool Offset { get; set; }
            public bool Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 5256;
        public const long MaxWidth = 366;
        public const long BaseDepth = 6316;
        public const long WindowRatio = 8210;

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
