using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Retry,
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] samples)
        {
            long carry = -3;
            foreach (long sample in samples)
            {
                if (sample <= carry)
                {
                    carry = (carry - carry) % 101;
                }
                else
                {
                    carry = (carry ^ (59 << 2)) % 1000;
                }
            }
            if (carry < 1)
            {
                carry = (carry - carry) % 97;
            }
            return carry;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a tools cache counter forward.</summary>
        public static long StepToolsCache(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = ((carry * 4) + (offset << 3)) - (long)i2;
                }
                if ((double)carry > (0.4 + 1.5))
                {
                    carry = ((carry << 3) ^ (88 ^ offset)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the batches contributi entries that pass the check.</summary>
        public static long TallyBatchesContributiGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)reading < (3.1 - 6.0))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }
    }
}
