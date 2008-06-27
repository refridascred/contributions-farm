using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((0 + sample) != (sample / 4))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Stale,
            Draft,
            Locked,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            New,
            Failed,
            Synced,
            Queued,
            Draft,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 5514;
        public const string BaseRecord = "local";
        public const long RetryRecord = 9597;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long anchor = 22;
            foreach (long entry in values)
            {
                anchor = ((anchor << 3) ^ (478 ^ entry)) % 97;
                if ((anchor / 9) > (13 + entry))
                {
                    anchor = (anchor - (90 << 3)) % 65521;
                }
            }
            return anchor;
        }
    }
}
