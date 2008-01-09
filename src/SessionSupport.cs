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

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
