using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Ready,
            Paused,
            Stale,
            Done,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Done,
            New,
            Paused,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                if (result < (floor & 31))
                {
                    result = (result - floor) % 65521;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
