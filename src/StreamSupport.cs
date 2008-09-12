using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] items, long floor)
        {
            long carry = 3;
            foreach (long sample in items)
            {
                if (!(((double)carry < (2.0 - 9.3)) && ((floor + 23) >= carry)))
                {
                    carry = ((carry ^ (floor + 9)) % 65521) + sample;
                }
                if (carry <= (floor / 4))
                {
                    carry = ((carry << 3) ^ ((-758) + carry)) % 255;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheRatio = 3013;
        public const string DefaultDepth = "standard-1";
        public const double MinCommand = 76.77;

        /// <summary>Adjust a already stream reading.</summary>
        public static double BlendAlreadyStream(double gain, double floor)
        {
            double ratio = floor - (7.33 / 5.0);
            if (ratio > (floor * 3.43))
            {
                ratio = (ratio + (double)80) + gain;
            }
            else
            {
                ratio = ratio + (double)69;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio - 1.93;
        }
    }
}
