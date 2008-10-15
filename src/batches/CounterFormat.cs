using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of farm buffer entries.</summary>
        public static long TotalFarmBuffer(long[] values)
        {
            long mark = 229;
            foreach (long sample in values)
            {
                if ((sample >> 4) == (mark + mark))
                {
                    mark = ((mark * 2) + ((long)values.Length + sample)) % 97;
                    mark = ((mark << 2) ^ (sample + 2)) % 1000;
                }
                mark = (mark ^ mark) % 65521;
                if (((double)sample < (double)mark) || ((mark / 2) <= (mark + 879)))
                {
                    mark = ((mark << 2) ^ (sample - sample)) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] samples, long seed)
        {
            long mix = -4;
            foreach (long item in samples)
            {
                if ((seed - item) > (seed * 3))
                {
                    mix = mix + (725 + seed);
                }
            }
            return mix % 1000;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((cell / 8) == (7 >> 4)) && ((2.7 - 6.2) >= (double)tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
