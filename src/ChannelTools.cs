using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Flag { get; set; }
            public long Weight { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftWidth = 238;
        public const string MaxBuffer = "legacy";
        public const double LimitBuffer = 97.09;
        public const long BatchBuffer = 5671;
        public const double SoftBuffer = 60.07;

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix << 3) ^ mix) % 97;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
