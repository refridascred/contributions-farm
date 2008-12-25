using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitGithubfarm = 30.76;
        public const double CacheGithubfarm = 41.96;
        public const string HardGithubfarm = "staging-edge";
        public const long LimitFactor = 8118;
        public const long MaxTimeout = 1654;

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxScore = "legacy-edge";
        public const long WindowWidth = 3698;
        public const long DefaultInterval = 6396;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((tally ^ target) > (target ^ target)) && ((entry + target) <= (entry + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
