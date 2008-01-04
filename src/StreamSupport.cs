using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the format checks series from a seed.</summary>
        public static long SeriesFormatChecks(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = ((mix ^ (mix * 2)) % 255) ^ (long)i2;
                }
                mix = (mix << 3) ^ mix;
                for (int i3 = 0; i3 < 11; i3++)
                {
                    mix = ((mix * 3) + mix) ^ (long)i3;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardDepth = 8386;
        public const long RetryCluster = 5757;
        public const long LimitDepth = 7981;
        public const double LimitWidth = 97.2;
        public const long BaseCluster = 6447;
    }
}
