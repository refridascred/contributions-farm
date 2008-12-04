using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate githubfarm cache readings against a bound.</summary>
        public static bool ValidateGithubfarmCacheLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BatchAlready = "stable-v2";
        public const long BaseCount = 3589;
        public const long BurstAlready = 9494;

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Total { get; set; }
            public bool Mode { get; set; }
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
