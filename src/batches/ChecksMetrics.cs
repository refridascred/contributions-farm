using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Size { get; set; }
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BaseScore = "alpha-edge";
        public const string BurstContext = "legacy-v2";
        public const string CacheContext = "legacy-1";
        public const long WindowWidth = 4987;
        public const long WindowScore = 9159;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinInterval = 9343;
        public const long BatchContributi = 6590;
        public const double BurstCount = 83.92;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Score { get; set; }
            public string Region { get; set; } = "";
            public double Owner { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
