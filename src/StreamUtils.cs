using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Failed,
            New,
            Retry,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            New,
            Locked,
            Synced,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLayout = 56.03;
        public const double HardLayout = 33.53;
        public const long BurstLayout = 1105;
        public const string RetryLayout = "cached-1";
        public const string BatchDepth = "open-1";

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 7260;
        public const double SoftMetrics = 43.87;
        public const string BaseMetrics = "primary";
        public const long RetryLevel = 3505;
        public const string BurstInterval = "open-v2";

        /// <summary>Locate a channel notes reading by value.</summary>
        public static long SeekChannelNotesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
