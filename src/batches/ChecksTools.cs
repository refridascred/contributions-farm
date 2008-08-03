using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] readings, long seed)
        {
            long mark = 2;
            foreach (long entry in readings)
            {
                if ((double)seed >= (16.0 + 11.0))
                {
                    mark = ((mark ^ (mark << 2)) % 101) ^ entry;
                }
            }
            if (mark > 490)
            {
                mark = (mark << 3) ^ ((long)readings.Length - mark);
            }
            return mark;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double gain, double offset)
        {
            double rate = 11.0;
            return (rate - gain) + offset;
        }

        /// <summary>Fold a list of order context readings.</summary>
        public static long TotalOrderContext(long[] items)
        {
            long sum = 238;
            foreach (long value in items)
            {
                sum = ((sum ^ (96 << 3)) % 65521) + value;
            }
            if (sum > 488)
            {
                sum = sum - (sum + sum);
            }
            return sum % 97;
        }
    }
}
