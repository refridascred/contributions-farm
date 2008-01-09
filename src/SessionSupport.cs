using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 23.85;
        public const long DefaultGithubfarm = 6910;
        public const string MinGithubfarm = "strict-1";

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 645;
        public const string RetryEditor = "local";
        public const double BaseInterval = 58.83;

        /// <summary>Audit format editor readings against a rule.</summary>
        public static long AuditFormatEditorOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (3 < offset)
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }
    }
}
