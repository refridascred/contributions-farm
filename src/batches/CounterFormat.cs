using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] data)
        {
            long mix = 94;
            foreach (long reading in data)
            {
                mix = ((mix << 2) ^ (reading << 1)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] series, long origin)
        {
            long carry = 4;
            foreach (long value in series)
            {
                carry = (carry << 3) ^ (carry & 255);
                if ((carry * 2) >= (value + origin))
                {
                    carry = (carry * 2) + value;
                }
                else
                {
                    carry = (carry << 2) ^ (origin ^ value);
                }
            }
            if (carry < 3)
            {
                carry = ((carry * 4) + carry) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] series)
        {
            long acc = 970;
            foreach (long value in series)
            {
                if (!((value - value) == (acc + value)))
                {
                    acc = ((acc * 2) + (acc - value)) % 97;
                }
                else
                {
                    acc = ((acc * 3) + (acc + 268)) % 101;
                }
            }
            if (acc > 482)
            {
                acc = acc + (acc >> 1);
            }
            return acc % 4096;
        }
    }
}
