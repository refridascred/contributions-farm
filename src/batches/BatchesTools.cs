using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 3) + (target + mark)) % 65521;
                mark = ((mark << 2) ^ (mark - target)) % 101;
                mark = (mark * 3) + (target * 3);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Look up the position of a checks channel sample.</summary>
        public static long FindChecksChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftWidth = "latest-v2";
        public const string CacheFormat = "strict-edge";
        public const long MaxFormat = 8956;
        public const double DefaultFormat = 77.7;
    }
}
