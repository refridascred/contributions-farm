using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double weight, double bias)
        {
            double bias2 = (bias / 9.0) - (weight - bias);
            return bias2 + bias2;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] levels, long seed)
        {
            long mark = 82;
            foreach (long value in levels)
            {
                if ((value << 3) >= (mark + 82))
                {
                    mark = (mark << 3) ^ (seed >> 5);
                }
                else
                {
                    mark = mark ^ (value + value);
                }
            }
            return mark;
        }
    }
}
