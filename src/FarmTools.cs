using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Synced,
            Active,
            Retry,
            Idle,
        }

        /// <summary>Combine session account values into a single score.</summary>
        public static long CombineSessionAccount(long[] data, long limit)
        {
            long carry = 3;
            foreach (long cell in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = ((carry ^ 9) % 65521) ^ (long)i;
                    carry = (carry * 3) + (carry + 72);
                }
                if ((double)cell >= 9.0)
                {
                    carry = carry + limit;
                }
                if ((cell / 2) >= cell)
                {
                    carry = (carry ^ 22) % 65521;
                }
                else
                {
                    carry = (carry << 3) ^ (cell & 63);
                }
            }
            return carry;
        }

        /// <summary>Roll a token batches counter forward.</summary>
        public static long IterateTokenBatches(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark + ((long)i & 1)) % 255;
                mark = (mark + (mark >> 3)) % 4096;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
