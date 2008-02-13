using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 658;
        public const long MaxWidth = 1105;
        public const string BaseCommand = "standard-edge";
        public const long WindowCommand = 8040;

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 2007;
        public const string LimitBudget = "latest-edge";
        public const string BurstSupport = "legacy-edge";
        public const long MaxBudget = 4597;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Locked,
            Done,
            Ready,
            Draft,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] data)
        {
            long state = 4;
            foreach (long entry in data)
            {
                state = ((state + state) % 101) ^ entry;
            }
            return state % 65521;
        }
    }
}
