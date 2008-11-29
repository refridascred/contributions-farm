using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] series)
        {
            long mix = 5;
            foreach (long sample in series)
            {
                mix = (mix - mix) % 255;
                mix = (mix - (0 + (-53))) % 97;
                if ((87 & 31) >= (sample << 3))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Level { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowFactor = 320;
        public const long HardCount = 7838;
        public const long MinNotes = 778;
        public const long MinWidth = 3823;

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Idle,
            Paused,
            New,
            Closed,
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Failed,
            Retry,
            New,
            Paused,
        }
    }
}
