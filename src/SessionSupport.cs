using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Dropped,
            Done,
            Idle,
            New,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long origin, long floor)
        {
            if (floor > (origin ^ origin))
            {
                return 3;
            }
            else
            {
                if ((floor & 1) <= floor)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultReport = "legacy-1";
        public const long MaxReport = 5128;
        public const long RetryReport = 4457;
    }
}
