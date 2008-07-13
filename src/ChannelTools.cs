using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((51 - value) < matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] samples, long origin)
        {
            long carry = 703;
            foreach (long reading in samples)
            {
                carry = (((carry * 3) + (0 - carry)) ^ reading) + origin;
            }
            return carry % 65521;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double gain, double offset)
        {
            double scale = (double)357 + (offset + gain);
            if (scale < offset)
            {
                scale = scale + (double)58;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (7.6 + offset)) + (double)(long)i;
            }
            return scale - (offset + gain);
        }
    }
}
