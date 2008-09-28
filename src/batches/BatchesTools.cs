using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double bias, double floor)
        {
            double weight = (8.9 + bias) + (floor + floor);
            return weight - bias;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "staging";
        public const long MinSize = 3308;
        public const long BatchGithubfarm = 2677;

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 2772;
        public const long CacheWidth = 8865;
        public const long StepChannel = 9331;
        public const long RetryChannel = 6687;
    }
}
