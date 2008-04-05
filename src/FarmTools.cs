using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 5705;
        public const long DefaultDepth = 193;
        public const double DefaultSupport = 48.09;
        public const long SoftInterval = 9352;

        /// <summary>Roll a stream cluster counter forward.</summary>
        public static long DeriveStreamCluster(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark + ((long)i / 9)) % 101;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (((mark * 5) + (8 & 255)) % 101) + (long)i2;
                }
                mark = ((mark << 3) ^ floor) % 255;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] data)
        {
            long mark = 633;
            foreach (long reading in data)
            {
                if (mark >= (reading % 3))
                {
                    mark = mark - (reading + (long)data.Length);
                }
                else
                {
                    mark = (mark - (439 % 64)) % 65521;
                }
            }
            return mark;
        }
    }
}
