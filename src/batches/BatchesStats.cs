using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((long)items.Length - offset) < (97 << 2))
                {
                    seen = (seen + 2) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] data)
        {
            long result = 496;
            foreach (long datum in data)
            {
                if (result <= (result >> 5))
                {
                    result = ((result * 3) + datum) % 65521;
                }
            }
            return result;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] levels)
        {
            long state = -848;
            foreach (long item in levels)
            {
                state = ((state << 2) ^ (state & 3)) % 4096;
                if ((7.5 - 8.54) <= (double)state)
                {
                    state = ((state * 5) + (state - item)) % 101;
                }
            }
            if (state < 6)
            {
                state = ((state * 3) + (state + state)) % 97;
            }
            return state;
        }
    }
}
