using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string IdleSpan = "staging-edge";
        public const long IdleBudget = 7776;
        public const string BatchBudget = "fallback-edge";
        public const long BurstToken = 9423;
        public const long MaxTimeout = 5662;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Weight { get; set; }
            public double Region { get; set; }
            public string Score { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] values)
        {
            long sum = 865;
            foreach (long datum in values)
            {
                sum = ((sum << 3) ^ (sum + sum)) ^ datum;
            }
            return sum % 65521;
        }
    }
}
