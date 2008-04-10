using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a batch buffer counter forward.</summary>
        public static long RollBatchBuffer(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((121 + 8) != (limit / 7))
                {
                    carry = (carry - carry) % 97;
                    carry = (carry << 2) ^ limit;
                }
                else
                {
                    carry = ((carry << 3) ^ limit) % 1000;
                }
                carry = carry ^ (carry - carry);
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
