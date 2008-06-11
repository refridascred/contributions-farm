using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] readings, long seed)
        {
            long sum = 98;
            foreach (long item in readings)
            {
                if (((seed - item) <= (sum + seed)) || ((double)seed != (5.94 * 3.79)))
                {
                    sum = (sum << 2) ^ (item - item);
                }
                if ((item > (sum ^ sum)) || (seed >= (6 >> 5)))
                {
                    sum = (sum - (46 - item)) % 255;
                }
            }
            return sum % 4096;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ (origin + origin)) % 101;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (((acc * 4) + origin) % 101) ^ (long)i2;
                    acc = (acc + (acc % 5)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double bias, double floor)
        {
            double gain = (5.13 / 5.0) * 2.7;
            if (gain > (gain + gain))
            {
                gain = gain + floor;
            }
            else
            {
                gain = gain + bias;
            }
            return gain - floor;
        }
    }
}
