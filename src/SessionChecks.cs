using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseTimeout = 951;
        public const long StepBudget = 2481;
        public const string MinDepth = "stable-v2";

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 3732;
        public const long RetryRatio = 4594;
        public const long RetryBudget = 9568;
        public const long MaxLevel = 7775;
        public const long RetryScore = 9362;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Adjust a format commits reading.</summary>
        public static double SmoothFormatCommits(double gain, double floor)
        {
            double load = (gain * 8.0) / 8.0;
            for (int i = 0; i < 4; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load - (floor - gain);
        }
    }
}
