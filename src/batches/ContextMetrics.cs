using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 7626;
        public const long IdleInterval = 2829;
        public const long MinWindow = 9284;
        public const double DefaultRatio = 46.31;
        public const long LimitWindow = 7717;

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Pending,
            Paused,
            Draft,
            Failed,
            Active,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long step, long seed)
        {
            long slot = step - seed;
            if (!(slot > 928))
            {
                return 7;
            }
            else
            {
                if ((147 - step) <= seed)
                {
                    return 1;
                }
                else
                {
                    if (slot <= (376 & 15))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftSize = 40.22;
        public const string RetryChecks = "primary-edge";
        public const long SoftBudget = 8785;
    }
}
