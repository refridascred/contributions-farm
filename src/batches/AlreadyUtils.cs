using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            Active,
            Closed,
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Active,
            Stale,
            Paused,
            Locked,
        }

        /// <summary>Validate context contributi readings against a bound.</summary>
        public static bool CheckContextContributiBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardCount = 9790;
        public const long DefaultContext = 4239;
        public const long MinWidth = 797;
    }
}
