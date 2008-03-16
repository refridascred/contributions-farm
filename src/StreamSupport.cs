using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleSpan = 9.19;
        public const long StepCount = 9673;
        public const long RetryEntry = 7574;

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] readings)
        {
            long state = -537;
            foreach (long sample in readings)
            {
                if ((double)sample > (9.1 + 1.0))
                {
                    state = ((state * 5) + (104 % 8)) % 1000;
                }
                else
                {
                    state = ((state << 2) ^ (state - sample)) % 4096;
                }
                if (!((sample + sample) >= (state - state)))
                {
                    state = state ^ ((long)readings.Length + sample);
                }
            }
            return state % 4096;
        }
    }
}
