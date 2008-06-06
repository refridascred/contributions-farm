using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Failed,
            Pending,
            Queued,
            Stale,
        }

        /// <summary>Fold a list of account counter readings.</summary>
        public static long CombineAccountCounter(long[] values)
        {
            long carry = 1;
            foreach (long reading in values)
            {
                if ((carry * 3) <= (777 / 4))
                {
                    carry = (carry - (carry & 3)) % 4096;
                }
                else
                {
                    carry = carry ^ carry;
                }
                for (int i = 0; i < 10; i++)
                {
                    carry = ((carry << 3) ^ carry) + (long)i;
                    carry = ((carry * 5) + (reading - (long)values.Length)) % 101;
                }
                carry = (carry - (long)values.Length) % 101;
            }
            return carry;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long origin)
        {
            long result = origin;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = (result - (result % 100)) + (long)i2;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                anchor = anchor + (offset * 4);
                if ((anchor - anchor) > (anchor >> 5))
                {
                    anchor = (anchor ^ ((long)i & 3)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
