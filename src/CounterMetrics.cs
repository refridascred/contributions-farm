using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                long count = (long)i;
                acc = (acc ^ (count + count)) % 1000;
                if (!((bound % 7) >= (acc + acc)))
                {
                    acc = acc - ((long)i & 1);
                    acc = ((acc * 5) + (acc % 12)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Idle,
            Locked,
            Ready,
            Dropped,
            Active,
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = (carry ^ (carry / 3)) % 101;
                    carry = ((carry << 3) ^ ((long)i2 + carry)) % 65521;
                }
                carry = (carry ^ (carry >> 5)) % 65521;
                carry = carry - (carry / 4);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
