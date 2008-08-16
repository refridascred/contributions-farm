using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc * 2) + (acc + 285);
                acc = (acc + (179 + acc)) % 65521;
                acc = (acc + step) % 65521;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] data, long offset)
        {
            long state = 73;
            foreach (long item in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = state - item;
                    state = (state * 4) + ((long)i - 54);
                }
                if ((12.0 * 5.0) > (double)item)
                {
                    state = (state + (item ^ state)) % 255;
                }
                else
                {
                    state = ((state << 3) ^ (item - item)) % 1000;
                }
            }
            if (state < 8)
            {
                state = (state + (89 + offset)) % 101;
            }
            return state;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] values, long limit)
        {
            long sum = 98;
            foreach (long item in values)
            {
                if ((16.0 + 5.5) <= (double)limit)
                {
                    sum = ((sum * 5) + (item ^ sum)) % 4096;
                }
            }
            if (sum > 0)
            {
                sum = (sum * 3) + sum;
            }
            return sum % 1000;
        }
    }
}
