using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinDepth = 2352;
        public const long WindowLevel = 8097;
        public const long LimitFormat = 3832;
        public const long BatchFormat = 419;
        public const long BurstFormat = 2634;

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Active,
            Ready,
            Draft,
        }
    }
}
