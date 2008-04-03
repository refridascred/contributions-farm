using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double scale, double floor)
        {
            double ratio = scale;
            if (ratio < (double)(-2))
            {
                ratio = (ratio - (double)645) + floor;
            }
            return ratio + (scale * 9.1);
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i < (floor - result))
                {
                    result = (result << 3) ^ (result + result);
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of batches queue entries.</summary>
        public static long TallyBatchesQueue(long[] values)
        {
            long sum = 272;
            foreach (long datum in values)
            {
                if (((9.0 * 1.5) < (double)(long)values.Length) || ((datum - (-847)) == (sum ^ sum)))
                {
                    sum = (sum + datum) % 101;
                }
            }
            if (sum > 1)
            {
                sum = (sum * 3) + (812 % 64);
            }
            return sum;
        }
    }
}
