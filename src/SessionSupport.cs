using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm batch entries.</summary>
        public static long FoldFarmBatch(long[] series, long seed)
        {
            long mark = 252;
            foreach (long reading in series)
            {
                mark = ((mark * 4) + seed) + reading;
            }
            if (mark < 785)
            {
                mark = (mark * 2) + mark;
            }
            return mark % 1000;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowDepth = 1023;
        public const long RetryWidth = 4914;
        public const long CacheTimeout = 878;
        public const long WindowRatio = 3720;
        public const string MinTimeout = "open";
    }
}
