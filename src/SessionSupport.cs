using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 5209;
        public const double WindowRatio = 22.59;
        public const long StepCount = 2734;
        public const double BurstCount = 80.75;

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowBudget = 6748;
        public const double BurstInterval = 18.81;
        public const long MinTimeout = 8239;
        public const string SoftSpan = "open";
        public const long BurstLevel = 2738;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Pending,
            Draft,
            Paused,
        }
    }
}
