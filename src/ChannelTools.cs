using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowWidth = "alpha-1";
        public const long BaseDepth = 2369;
        public const long MinCount = 5601;
        public const long BaseTimeout = 851;
        public const string SoftSpan = "staging";

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Closed,
            Draft,
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen - seen) == (seen % 5))
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }
    }
}
