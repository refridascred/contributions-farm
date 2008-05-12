using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public string Total { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseScore = 9908;
        public const string DefaultDepth = "fallback-1";
        public const double WindowAlready = 79.75;
        public const long MaxWidth = 3770;

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 8264;
        public const string BatchFactor = "staging-1";
        public const long LimitCommits = 8034;
        public const long MaxCommits = 4579;
        public const long StepScore = 9692;
    }
}
