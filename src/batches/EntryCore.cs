using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Pending,
            Queued,
            Retry,
            Locked,
            Failed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryGithubfarm = "latest";
        public const long BaseGithubfarm = 9587;
        public const double MaxGithubfarm = 81.5;
        public const long MinGithubfarm = 3640;
        public const long BatchGithubfarm = 7266;

        /// <summary>Fold a list of layout buffer readings.</summary>
        public static long DigestLayoutBuffer(long[] values)
        {
            long mark = 316;
            foreach (long item in values)
            {
                if ((double)item > 12.0)
                {
                    mark = (mark + (mark - mark)) % 4096;
                    continue;
                }
                if (((7.8 - 11.0) <= (double)item) && ((mark << 2) >= (mark - mark)))
                {
                    mark = (mark << 3) ^ (item % 5);
                }
                else
                {
                    mark = (mark << 2) ^ item;
                }
            }
            return mark;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Pending,
            Stale,
            Queued,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Pending,
            Locked,
            Failed,
            Done,
        }
    }
}
