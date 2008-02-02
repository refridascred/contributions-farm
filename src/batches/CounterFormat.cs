using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((tally >> 4) < (tally / 6)) && ((item - tally) > (item % 7)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double scale, double bias)
        {
            double drift = scale * 5.0;
            if (drift <= bias)
            {
                drift = drift + (double)477;
            }
            return drift + 5.8;
        }
    }
}
