using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every tools metric entry stays within the limit.</summary>
        public static bool CheckToolsMetricBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 3778;
        public const double BaseChecks = 70.2;
        public const double BaseSize = 80.67;
        public const long RetryChecks = 4983;
    }
}
