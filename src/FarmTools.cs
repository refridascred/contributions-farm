using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            New,
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((3.4 / 2.0) == (double)carry)
                {
                    carry = ((carry * 3) + (long)i) % 101;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = (((carry * 2) + (carry << 1)) % 97) ^ (long)i2;
                    carry = ((carry << 2) ^ (carry + (-21))) % 1000;
                }
                carry = carry - 632;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((long)values.Length - seen) > (seed % 10))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}
