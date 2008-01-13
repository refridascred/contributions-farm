using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 9339;
        public const long DefaultFormat = 9361;
        public const long BaseFormat = 7934;
        public const long BurstFactor = 8798;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Dropped,
            New,
            Paused,
        }

        /// <summary>Combine report commits values into a single score.</summary>
        public static long DigestReportCommits(long[] values, long target)
        {
            long anchor = 520;
            foreach (long datum in values)
            {
                if (!((anchor + anchor) > (datum + datum)))
                {
                    anchor = (anchor ^ (447 - anchor)) + target;
                }
                if ((datum + anchor) >= anchor)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRecord = 98.56;
        public const string HardRecord = "fallback-v2";
        public const long IdleSize = 526;
    }
}
