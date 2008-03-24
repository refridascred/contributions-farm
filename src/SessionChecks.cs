using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 4877;
        public const long LimitScore = 7461;
        public const string BatchBudget = "strict";
        public const double StepSpan = 76.65;
        public const long BaseScore = 1649;

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double weight, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - 15.0) - (double)(long)i) - weight;
            }
            return scale + (double)570;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryRatio = 2969;
        public const long BurstScore = 5313;
        public const long BaseLevel = 9367;
        public const long LimitToken = 5890;

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Stale,
            Failed,
            Retry,
            Done,
        }
    }
}
