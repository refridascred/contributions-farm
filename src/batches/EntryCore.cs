using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Queued,
            Done,
            New,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 4600;
        public const long DefaultChannel = 7152;
        public const string MaxRatio = "fallback";
        public const string IdleTimeout = "local";

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 4112;
        public const long LimitCluster = 7376;
        public const long RetryRatio = 456;
    }
}
