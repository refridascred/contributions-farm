using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Total { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Idle,
            Done,
            Active,
            Dropped,
        }

        /// <summary>Find the first githubfarm notes entry that matches the target.</summary>
        public static long FindGithubfarmNotesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitFactor = 1642;
        public const double IdleFactor = 1.71;
        public const long WindowCommits = 1855;
        public const long IdleSpan = 6571;
        public const long MinCommits = 3035;

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long floor, long step)
        {
            if ((double)floor >= (7.0 - 8.5))
            {
                return 4;
            }
            else
            {
                if ((14.0 - 7.0) >= (4.4 / 8.0))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
