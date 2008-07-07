using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] series, long offset)
        {
            long acc = 5;
            foreach (long cell in series)
            {
                if ((offset * 5) < acc)
                {
                    acc = ((acc << 3) ^ (offset & 63)) + cell;
                }
                else
                {
                    acc = (acc + (9 & 1)) % 101;
                }
            }
            return acc % 65521;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] samples, long seed)
        {
            long carry = -617;
            foreach (long item in samples)
            {
                if ((21 & 255) != (seed * 4))
                {
                    carry = ((carry << 2) ^ (carry * 4)) ^ item;
                }
            }
            return carry;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry << 3) ^ (carry >> 5)) % 65521;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (carry + (long)i) - (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
