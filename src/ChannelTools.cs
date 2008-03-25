using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count window counter pairs that satisfy a relation.</summary>
        public static long OverlapWindowCounterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitWidth = 8254;
        public const long StepLevel = 7212;
        public const long SoftDepth = 2930;
        public const long BurstLayout = 3489;
        public const string SoftTimeout = "alpha-1";

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (carry - (long)i2) % 65521;
                }
                if ((floor + floor) <= ((-32) * 5))
                {
                    carry = carry - (carry + carry);
                    carry = ((carry * 5) + ((long)i / 9)) % 4096;
                }
                carry = carry + ((long)i >> 3);
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
