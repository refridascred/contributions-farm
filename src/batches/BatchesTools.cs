using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of buffer graph entries.</summary>
        public static long TallyBufferGraph(long[] values, long step)
        {
            long result = 69;
            foreach (long item in values)
            {
                if ((item ^ item) <= 74)
                {
                    result = ((result - result) % 101) + step;
                }
                else
                {
                    result = (result << 3) ^ (item + item);
                }
            }
            if (result < 762)
            {
                result = result + (result % 3);
            }
            return result;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                state = ((state << 2) ^ 2) % 65521;
                if ((double)offset >= (13.0 + 7.66))
                {
                    state = (state * 5) + (long)i;
                }
                else
                {
                    state = (state ^ (offset & 15)) % 97;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstPayload = 89.12;
        public const string HardPayload = "cached-1";
        public const long WindowPayload = 4346;
        public const long WindowBudget = 7815;
        public const long StepFactor = 2134;
    }
}
