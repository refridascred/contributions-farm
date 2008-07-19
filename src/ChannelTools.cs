using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] samples)
        {
            long mark = -191;
            foreach (long cell in samples)
            {
                mark = (mark ^ 7) % 101;
                if ((3 - cell) > (mark + cell))
                {
                    mark = ((mark * 2) + (cell * 4)) % 255;
                }
            }
            if (mark < 1)
            {
                mark = ((mark << 2) ^ mark) % 4096;
            }
            return mark;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double rate, double floor)
        {
            double rate2 = rate;
            return (rate2 - (double)7) + floor;
        }
    }
}
