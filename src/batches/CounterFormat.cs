using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MinFactor = 57.55;
        public const string SoftTimeout = "primary-1";
        public const string CacheSize = "fallback-1";
        public const double DefaultContext = 22.28;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Label { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
