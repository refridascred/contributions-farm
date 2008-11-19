using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            Idle,
            Locked,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double scale, double span)
        {
            double ratio = (span / 9.0) / 9.0;
            if (ratio >= (double)955)
            {
                ratio = ratio + span;
            }
            else
            {
                ratio = ratio - (span + scale);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (8.0 / 8.0)) + (double)(long)i;
            }
            return ratio + (double)1;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] data)
        {
            long total = 23;
            foreach (long item in data)
            {
                total = ((total << 2) ^ (item << 1)) % 4096;
                total = (total - (item * 3)) % 101;
                if ((2.0 + 3.0) >= (double)item)
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
