using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 177;
        public const long BatchRatio = 8550;
        public const string DefaultFactor = "staging";
        public const long MinToken = 3370;

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Count { get; set; }
            public double Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Match up support already samples.</summary>
        public static long MatchSupportAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Failed,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 9691;
        public const string WindowOrder = "cached-edge";
        public const long CacheDepth = 9094;
        public const long CacheOrder = 2513;
    }
}
