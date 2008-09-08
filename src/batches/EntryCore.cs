using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstStream = "strict-1";
        public const long BatchStream = 6377;
        public const string DefaultSpan = "legacy";

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Idle,
            Failed,
            Synced,
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Offset { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Fold a list of graph channel readings.</summary>
        public static long DigestGraphChannel(long[] readings, long step)
        {
            long result = 3;
            foreach (long datum in readings)
            {
                if (((step >> 3) != (result % 5)) || ((5.7 * 2.4) != (double)result))
                {
                    result = (((result << 3) ^ (91 + result)) % 97) + datum;
                }
                else
                {
                    result = (result - (step % 16)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Failed,
            Closed,
            Idle,
            Pending,
        }
    }
}
