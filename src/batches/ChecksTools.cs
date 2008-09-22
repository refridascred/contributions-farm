using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 3960;
        public const string WindowSpan = "local-1";
        public const string DefaultMetrics = "latest-edge";

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double weight, double floor)
        {
            double load = 7.9;
            if (load >= 1.0)
            {
                load = (load + load) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (13.0 + floor)) + (double)(long)i;
            }
            return load - floor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepEntry = "staging";
        public const long SoftWidth = 6610;
        public const long IdleEntry = 3929;

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 6344;
        public const long BurstSession = 4613;
        public const long BurstTimeout = 676;
    }
}
