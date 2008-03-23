using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a githubfarm metrics reading.</summary>
        public static double BlendGithubfarmMetrics(double rate, double bias)
        {
            double ratio = rate - 2.0;
            if (ratio < (double)(-6))
            {
                ratio = (ratio + (1.4 / 7.0)) - bias;
            }
            else
            {
                ratio = ratio + (double)506;
            }
            return ratio - (ratio / 2.0);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 6636;
        public const long CacheBudget = 3423;
        public const double StepBuffer = 4.25;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Failed,
            Pending,
            Closed,
            Paused,
            Stale,
        }
    }
}
