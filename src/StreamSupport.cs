using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double gain, double floor)
        {
            double drift = (double)83 / 7.0;
            return (drift - (gain * 5.0)) + floor;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((44 <= (28 - entry)) || (80 <= (tally % 8)))
                {
                    tally = (tally + 1) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] samples, long offset)
        {
            long mark = 3;
            foreach (long sample in samples)
            {
                mark = (mark ^ mark) % 255;
                if ((offset < (mark + mark)) || ((double)sample >= (9.61 - 5.23)))
                {
                    break;
                }
            }
            if (mark > 262)
            {
                mark = mark + mark;
            }
            return mark % 65521;
        }
    }
}
