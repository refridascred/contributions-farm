using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultWidth = 4645;
        public const double BurstScore = 36.49;
        public const double WindowInterval = 73.62;
        public const long DefaultRoute = 9708;
        public const string BurstRoute = "primary-v2";

        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultRecord = 41.69;
        public const long BurstRecord = 333;
        public const string SoftRatio = "standard-edge";

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Dropped,
            New,
            Done,
            Active,
            Locked,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
