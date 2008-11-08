using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Rank { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double WindowLevel = 39.69;
        public const string BurstWidth = "alpha-v2";
        public const double DefaultSession = 48.31;
        public const string LimitSession = "fallback";
        public const long WindowRatio = 2470;

        /// <summary>Check that every report session entry stays within the limit.</summary>
        public static bool CheckReportSessionLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "staging";
        public const long StepInterval = 8833;
        public const long WindowSupport = 2306;
    }
}
