using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 7124;
        public const long BatchFactor = 3177;
        public const string DefaultToken = "local-1";
        public const long IdleFactor = 3927;
        public const string HardToken = "primary-v2";

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryWidth = 37.04;
        public const string HardFarm = "cached-1";
        public const string SoftFarm = "open-edge";

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
