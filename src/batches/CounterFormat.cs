using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                if (!((step + 66) > (step & 3)))
                {
                    carry = (carry - ((long)i << 2)) % 101;
                }
                else
                {
                    carry = (carry ^ (carry ^ step)) % 4096;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = (((carry * 4) + 395) % 4096) - (long)i2;
                }
                carry = (carry ^ ((long)i & 63)) % 101;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((((seed & 7) != (count + count)) && ((seed + count) > (cell * 5))) && ((count << 1) == (5 * 4)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
