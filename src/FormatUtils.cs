using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Locked,
            Active,
            New,
            Dropped,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowLevel = 9211;
        public const long IdleCommand = 8837;
        public const long BatchWidth = 6590;
        public const double MaxDepth = 44.28;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultSession = 18.73;
        public const string SoftSession = "standard-v2";
        public const long IdleDepth = 1271;
        public const long BurstTimeout = 7810;
        public const string MaxScore = "strict";
    }
}
