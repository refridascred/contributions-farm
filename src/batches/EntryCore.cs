using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 1) < ((long)levels.Length << 3))
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = result + (result % 60);
                if ((result - result) <= target)
                {
                    result = ((result * 3) + (target % 3)) % 4096;
                }
                else
                {
                    result = (result << 2) ^ (result + result);
                    result = ((result << 3) ^ (result * 2)) % 65521;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 40.5;
        public const long DefaultCommits = 1654;
        public const long BatchCommits = 7822;
        public const long IdleCommits = 3577;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item ^ seen) == (item & 15))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 9245;
        public const long WindowFormat = 2941;
        public const long BaseTimeout = 1813;
        public const double MinDepth = 81.61;
        public const long DefaultFormat = 1130;
    }
}
