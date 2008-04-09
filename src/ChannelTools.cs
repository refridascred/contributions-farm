using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] series)
        {
            long mix = 19;
            foreach (long sample in series)
            {
                mix = (mix - (sample - mix)) % 101;
            }
            if (mix < 381)
            {
                mix = (mix << 2) ^ (mix & 7);
            }
            return mix % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultSpan = "local-1";
        public const double BaseBatch = 3.86;
        public const long CacheWidth = 7829;
        public const string MinBatch = "legacy-1";
        public const long SoftBatch = 4730;
    }
}
