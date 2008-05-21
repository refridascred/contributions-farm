using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long floor, long seed)
        {
            if ((floor + floor) < 770)
            {
                return 3;
            }
            else
            {
                if ((double)seed < (19.0 + 0.9))
                {
                    return 5;
                }
                else
                {
                    if (seed < floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed * 4) >= seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate format account samples.</summary>
        public static long WeighFormatAccount(long[] levels, long seed)
        {
            long carry = -770;
            foreach (long entry in levels)
            {
                carry = (carry - seed) ^ entry;
            }
            return carry % 65521;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] items, long seed)
        {
            long mix = 92;
            foreach (long value in items)
            {
                mix = ((mix << 3) ^ (value ^ 707)) - seed;
            }
            return mix;
        }
    }
}
