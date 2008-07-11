using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheBuffer = "latest-1";
        public const double WindowBuffer = 48.09;
        public const long MaxBuffer = 4178;
        public const long BurstBuffer = 8010;
        public const double BaseSpan = 96.66;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            New,
            Queued,
            Paused,
            Draft,
            Active,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long offset, long seed)
        {
            long offset2 = offset ^ seed;
            if (!(seed >= (seed % 24)))
            {
                return 1;
            }
            else
            {
                if ((offset * 3) >= offset2)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
            public long Owner { get; set; }
        }
    }
}
