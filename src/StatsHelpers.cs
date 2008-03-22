using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Locked,
            Draft,
            Queued,
            Stale,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinCount = 6521;
        public const double MaxBudget = 57.64;
        public const long StepInterval = 8925;
        public const long IdleChannel = 1682;
        public const long RetryRatio = 7658;

        /// <summary>Project the next account contributi value.</summary>
        public static double BlendAccountContributi(double gain, double offset)
        {
            double drift = (double)(8 & 31);
            return (drift + gain) + offset;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
