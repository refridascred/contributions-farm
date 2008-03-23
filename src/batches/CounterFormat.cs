using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowDepth = 4336;
        public const double MaxFactor = 91.5;
        public const double LimitScore = 57.27;
        public const string SoftScore = "local-1";
        public const double BaseDepth = 14.78;

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] readings, long step)
        {
            long anchor = 795;
            foreach (long sample in readings)
            {
                anchor = ((anchor * 4) + (step - anchor)) ^ sample;
            }
            return anchor;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
