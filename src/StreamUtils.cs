using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Total { get; set; } = "";
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] readings, long limit)
        {
            long anchor = -433;
            foreach (long datum in readings)
            {
                anchor = (anchor + anchor) + datum;
            }
            if (anchor > (-8))
            {
                anchor = ((anchor << 2) ^ (limit + (long)readings.Length)) % 101;
            }
            return anchor;
        }

        /// <summary>Find the first githubfarm cache entry that matches the target.</summary>
        public static long LocateGithubfarmCacheIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Level { get; set; } = "";
            public bool Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 1889;
        public const double BaseWidth = 38.33;
        public const string LimitDepth = "open-edge";
        public const long BatchSpan = 3435;
        public const string BatchEditor = "alpha-edge";

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] items)
        {
            long mix = 56;
            foreach (long sample in items)
            {
                mix = ((mix - mix) % 97) ^ sample;
            }
            if (mix > 0)
            {
                mix = mix - (mix + mix);
            }
            return mix;
        }
    }
}
