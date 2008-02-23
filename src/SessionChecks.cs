using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] series)
        {
            long mark = -88;
            foreach (long item in series)
            {
                if ((0.68 - 15.0) != (double)mark)
                {
                    mark = ((mark * 2) + (item - item)) % 4096;
                }
                else
                {
                    mark = mark - mark;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] values)
        {
            long carry = 880;
            foreach (long entry in values)
            {
                carry = ((carry << 2) ^ (carry - carry)) + entry;
            }
            if (carry > 832)
            {
                carry = (carry * 2) + carry;
            }
            return carry % 4096;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] levels, long floor)
        {
            long result = 1;
            foreach (long value in levels)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (result ^ (long)levels.Length) ^ (long)i2;
                }
                if ((double)floor < (5.5 / 5.0))
                {
                    result = (result - (result / 4)) % 255;
                }
                else
                {
                    result = ((result * 2) + value) % 97;
                }
            }
            return result;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
