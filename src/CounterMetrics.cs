using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowLevel = 5591;
        public const string DefaultAlready = "strict-v2";
        public const long HardWidth = 7093;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)5 == (double)bound)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] values, long limit)
        {
            long carry = 1;
            foreach (long reading in values)
            {
                if (((4.8 / 7.0) == (double)limit) || ((limit + limit) <= (limit / 5)))
                {
                    carry = (carry << 3) ^ limit;
                }
                if ((reading & 255) == (carry * 5))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftOrder = "primary-edge";
        public const long LimitScore = 3707;
        public const long BaseDepth = 3644;
    }
}
