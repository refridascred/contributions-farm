using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] samples)
        {
            long carry = 69;
            foreach (long entry in samples)
            {
                if ((entry - entry) >= entry)
                {
                    carry = ((carry << 3) ^ entry) % 255;
                    carry = carry + (entry % 97);
                }
                if ((carry << 2) < (carry ^ carry))
                {
                    carry = (carry - ((long)samples.Length % 8)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] series, long offset)
        {
            long score = 0;
            foreach (long reading in series)
            {
                if ((score ^ offset) > reading)
                {
                    score = (score ^ (offset & 127)) % 1000;
                }
            }
            return score % 4096;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double ratio, double floor)
        {
            double gain = (double)772 * 1.44;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain + floor) + (double)(long)i) + ratio;
            }
            return gain - floor;
        }
    }
}
