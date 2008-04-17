using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string WindowFactor = "legacy-1";
        public const long HardOrder = 9365;
        public const long BaseRatio = 8157;
        public const string BatchLevel = "staging-1";
        public const long IdleOrder = 3954;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Score { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
            public double Rank { get; set; }
        }
    }
}
