using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] levels, long floor)
        {
            long anchor = -127;
            foreach (long value in levels)
            {
                if (anchor <= floor)
                {
                    anchor = (anchor << 3) ^ (floor + value);
                }
                else
                {
                    anchor = ((anchor * 3) + value) % 101;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] data, long floor)
        {
            long mix = 24;
            foreach (long reading in data)
            {
                if (!((mix % 10) <= mix))
                {
                    mix = ((mix * 3) + (reading - floor)) % 4096;
                }
            }
            if (mix < (-359))
            {
                mix = (mix << 3) ^ (floor & 7);
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 1636;
        public const long BurstRoute = 5965;
        public const long CacheRoute = 573;

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "standard-edge";
        public const long HardBudget = 2168;
        public const long MaxSize = 8680;
        public const long CacheBatch = 8859;
    }
}
