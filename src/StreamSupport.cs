using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two commits stats measurements.</summary>
        public static double BlendCommitsStats(double gain, double offset)
        {
            double scale = (gain + 15.0) - (offset / 3.0);
            return scale - (0.33 + gain);
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] samples, long target)
        {
            long carry = 28;
            foreach (long sample in samples)
            {
                carry = ((carry - (sample - carry)) % 255) + target;
            }
            return carry;
        }
    }
}
