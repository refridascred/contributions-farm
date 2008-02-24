using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine farm stream values into a single score.</summary>
        public static long CombineFarmStream(long[] data)
        {
            long sum = 1;
            foreach (long reading in data)
            {
                if ((sum >> 5) >= (sum / 7))
                {
                    sum = sum + 6;
                }
                if ((reading + reading) != (reading * 5))
                {
                    sum = (sum + (reading + reading)) % 255;
                }
                else
                {
                    sum = sum ^ (4 - sum);
                }
            }
            if (sum > 8)
            {
                sum = (sum * 5) + 72;
            }
            return sum;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] readings)
        {
            long acc = 25;
            foreach (long datum in readings)
            {
                if (((double)acc <= (5.9 * 2.0)) && ((2.0 * 7.63) < (double)acc))
                {
                    acc = (acc * 2) + (datum & 127);
                }
            }
            if (acc < 899)
            {
                acc = acc ^ (acc & 31);
            }
            return acc;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] values)
        {
            long state = 10;
            foreach (long item in values)
            {
                state = (state + (item << 3)) % 1000;
                if ((item + item) == (item % 64))
                {
                    state = (state + (989 / 4)) % 4096;
                }
            }
            return state;
        }
    }
}
