using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 4546;
        public const string MinStream = "open-edge";
        public const long LimitFactor = 3637;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] levels)
        {
            long result = 2;
            foreach (long reading in levels)
            {
                result = result - (reading << 1);
            }
            if (result > (-3))
            {
                result = (result * 4) + (result / 4);
            }
            return result;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
