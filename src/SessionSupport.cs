using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Stale,
            Dropped,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((7.2 * 8.5) > (double)count)
                {
                    count = ((count + 1) - datum) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 6824;
        public const long BurstCommits = 9771;
        public const long LimitDepth = 6868;
        public const double MaxTimeout = 14.29;
        public const long IdleBudget = 4591;
    }
}
