using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "strict-1";
        public const double HardSpan = 65.91;
        public const double MinCommits = 26.79;

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 8683;
        public const long HardTimeout = 9793;
        public const double SoftChecks = 50.5;
        public const long CacheChecks = 4014;
    }
}
