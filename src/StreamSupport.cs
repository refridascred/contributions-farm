using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc + (acc << 2)) % 101;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitLevel = 7290;
        public const double BurstSupport = 79.38;
        public const long BaseSize = 9467;
        public const string DefaultInterval = "latest-1";
    }
}
