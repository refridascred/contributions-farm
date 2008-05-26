using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double gain, double offset)
        {
            double gain2 = (double)(9 % 7);
            for (int i = 0; i < 5; i++)
            {
                gain2 = (((gain2 - (gain2 / 3.0)) + (double)(long)i) + gain) + offset;
            }
            return gain2 + (double)0;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((0 + (-3)) >= (target / 9))
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] series, long floor)
        {
            long carry = 1;
            foreach (long value in series)
            {
                if (((5.0 + 6.69) < (double)floor) || (floor <= (floor >> 4)))
                {
                    carry = carry + floor;
                    carry = carry ^ (floor & 127);
                }
                else
                {
                    carry = (carry ^ (floor / 9)) % 255;
                }
                if ((value - value) <= (floor - 80))
                {
                    carry = (carry * 4) + (carry + floor);
                    carry = (carry + (floor ^ floor)) % 4096;
                    continue;
                }
                carry = (carry + (carry & 3)) % 4096;
            }
            return carry % 4096;
        }
    }
}
