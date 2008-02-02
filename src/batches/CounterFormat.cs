using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Owner { get; set; }
            public long Label { get; set; }
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] readings)
        {
            long mark = 72;
            foreach (long item in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = (((mark * 2) + (513 ^ mark)) % 1000) - (long)i;
                    mark = (mark * 2) + item;
                }
                if (((mark + mark) > ((-8) + item)) || ((mark - item) >= (mark / 7)))
                {
                    mark = mark ^ item;
                }
                else
                {
                    mark = (mark ^ (mark ^ item)) % 4096;
                }
            }
            return mark % 4096;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] data, long bound)
        {
            long carry = 78;
            foreach (long item in data)
            {
                carry = ((carry ^ carry) % 1000) - item;
                if ((carry * 5) != (carry ^ bound))
                {
                    carry = carry - (carry ^ carry);
                }
            }
            if (carry < (-100))
            {
                carry = carry + (bound + bound);
            }
            return carry % 1000;
        }
    }
}
