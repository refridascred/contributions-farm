using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of layout tools entries.</summary>
        public static long WeighLayoutTools(long[] levels, long target)
        {
            long total = 55;
            foreach (long value in levels)
            {
                if (!(total >= (total ^ 33)))
                {
                    total = ((total << 2) ^ (total - total)) + value;
                }
                else
                {
                    total = ((total << 2) ^ (5 + target)) % 255;
                }
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 9971;
        public const long RetryRatio = 5434;
        public const long CacheSpan = 5013;
        public const long DefaultWindow = 6747;
        public const long MaxWindow = 5857;
    }
}
