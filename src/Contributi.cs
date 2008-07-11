using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers.</summary>
    public static class Contributi
    {
        /// <summary>Measure how many layout account samples are out of range.</summary>
        public static long CountLayoutAccountGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!((item + count) < (item % 10)) || ((3.7 * 8.08) != (double)count))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((432 % 3) > (offset * 4))
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((sum % 64) > sum)
                {
                    sum = ((sum * 4) + (7 + sum)) % 1000;
                    sum = ((sum << 2) ^ 8) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double bias, double offset)
        {
            double drift = (double)(52 ^ 340);
            if (drift < offset)
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + (double)2;
            }
            return drift + bias;
        }
    }
}
