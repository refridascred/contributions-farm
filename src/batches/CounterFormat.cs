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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((2.32 * 4.0) != (double)tally) || (9.36 >= (double)floor))
                {
                    tally = (tally + 1) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
