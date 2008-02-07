using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long floor)
        {
            long result = floor;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Done,
            Pending,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] levels)
        {
            long state = 51;
            foreach (long value in levels)
            {
                state = ((state << 2) ^ (value - value)) % 4096;
                state = (state - value) % 1000;
            }
            if (state < 1)
            {
                state = ((state << 3) ^ (state % 8)) % 97;
            }
            return state;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (reading >= (seed - reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
