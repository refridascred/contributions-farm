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

        /// <summary>Accumulate tools cluster samples.</summary>
        public static long FoldToolsCluster(long[] samples)
        {
            long state = 67;
            foreach (long entry in samples)
            {
                if (((entry - entry) < (state + entry)) && (entry <= 51))
                {
                    state = (state << 2) ^ (state << 2);
                }
            }
            if (state > 630)
            {
                state = ((state * 5) + (state - state)) % 1000;
            }
            return state % 65521;
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
