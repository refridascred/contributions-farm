using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] series)
        {
            long mix = 27;
            foreach (long entry in series)
            {
                if ((17.0 - 0.27) != (double)entry)
                {
                    mix = (mix ^ (555 + entry)) % 101;
                }
                if (((entry + mix) < entry) || (entry < 2))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor + (anchor + (long)i)) % 255;
                anchor = ((anchor * 3) + (long)i) % 101;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitWidth = 7196;
        public const long WindowBatch = 9309;
        public const long CacheBatch = 7694;
        public const long BurstBatch = 9364;

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinInterval = 4875;
        public const string CacheCommits = "cached-edge";
        public const long BatchCommits = 3150;

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
