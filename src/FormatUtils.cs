using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Synced,
            Idle,
            Paused,
            Draft,
            Active,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of contributi window readings.</summary>
        public static long WeighContributiWindow(long[] samples)
        {
            long anchor = 86;
            foreach (long cell in samples)
            {
                anchor = ((anchor - (anchor % 16)) % 4096) + cell;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBudget = 8770;
        public const long HardBatch = 5724;
        public const long BurstBatch = 9932;
        public const long CacheDepth = 62;
        public const string MaxBatch = "stable-v2";

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultLevel = 64.79;
        public const long BatchSupport = 9303;
        public const long BaseSupport = 6255;
        public const double RetrySupport = 70.85;
    }
}
