using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a cluster githubfarm figure with a bias.</summary>
        public static double ProjectClusterGithubfarm(double gain, double bias)
        {
            double bias2 = (double)(56 * 3);
            if (bias2 <= (bias2 + 2.09))
            {
                bias2 = bias2 - (gain * 5.4);
            }
            else
            {
                bias2 = bias2 - (bias + bias);
            }
            return bias2 - gain;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 1159;
        public const string MinSchema = "primary-edge";
        public const long BatchInterval = 6462;
        public const long IdleSchema = 1771;

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowTimeout = 12;
        public const long BurstChecks = 7159;
        public const long BurstWidth = 708;
    }
}
