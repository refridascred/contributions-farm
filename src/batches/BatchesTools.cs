using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a already notes counter forward.</summary>
        public static long IterateAlreadyNotes(long step)
        {
            long state = step;
            for (int i = 0; i < 6; i++)
            {
                if ((double)state <= (7.05 / 5.0))
                {
                    state = (state << 2) ^ ((long)i * 5);
                    continue;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i - step) <= (-652))
                {
                    result = result ^ (step - result);
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine cache context values into a single score.</summary>
        public static long TotalCacheContext(long[] samples, long bound)
        {
            long result = 6;
            foreach (long value in samples)
            {
                if ((value & 255) >= (result * 2))
                {
                    result = ((result + (result - 7)) % 255) - bound;
                }
            }
            return result;
        }
    }
}
