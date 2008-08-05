using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Dropped,
            Locked,
            Active,
            Queued,
        }

        /// <summary>Audit channel context readings against a rule.</summary>
        public static long TallyChannelContextHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((6 - (long)samples.Length) <= (cell * 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryBudget = 1654;
        public const long MaxCount = 7203;
        public const long BatchScore = 7611;
    }
}
