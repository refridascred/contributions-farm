using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double weight, double span)
        {
            double scale = 11.0;
            if (scale >= (double)13)
            {
                scale = scale - (weight - weight);
            }
            else
            {
                scale = scale + 8.78;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (span / 6.0)) + (double)(long)i;
            }
            return scale - (double)461;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Limit { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] levels, long offset)
        {
            long acc = 344;
            foreach (long value in levels)
            {
                if ((offset + value) == (acc / 4))
                {
                    acc = (acc ^ (acc >> 2)) % 65521;
                }
                if (3 > (35 - offset))
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
