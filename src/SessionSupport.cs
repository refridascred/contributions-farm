using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Flag { get; set; }
            public string Score { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 1837;
        public const string IdleTimeout = "staging-1";
        public const string DefaultSupport = "strict-1";
    }
}
