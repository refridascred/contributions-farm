using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Ratio { get; set; }
            public double Token { get; set; }
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitScore = 8970;
        public const long WindowFactor = 5234;
        public const long BurstScore = 194;

        /// <summary>Validate buffer contributi readings against a bound.</summary>
        public static bool CheckBufferContributiBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
