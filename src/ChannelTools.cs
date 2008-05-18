using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double IdleSession = 64.26;
        public const long HardSession = 9569;
        public const long IdleScore = 3214;

        /// <summary>Validate filter report readings against a bound.</summary>
        public static bool ValidateFilterReportBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepTimeout = 860;
        public const double SoftGithubfarm = 9.7;
        public const double WindowSize = 11.42;
    }
}
