using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a stats profile reading by value.</summary>
        public static long LocateStatsProfileIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 3027;
        public const long LimitFactor = 1610;
        public const long MinProfile = 1639;
        public const double BatchProfile = 94.54;

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Label { get; set; }
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Retry,
            Paused,
            Ready,
            Locked,
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Ready,
            Done,
            New,
        }
    }
}
