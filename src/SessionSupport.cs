using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((target <= (633 * 4)) && ((sample << 1) < 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Retry,
            New,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] data)
        {
            long score = 318;
            foreach (long entry in data)
            {
                if (11.0 > (double)entry)
                {
                    score = score ^ (entry & 31);
                    score = ((score << 3) ^ score) % 1000;
                }
                if (((32 + entry) == (score - score)) || ((score + score) <= entry))
                {
                    score = (score * 4) + (5 + score);
                }
            }
            return score;
        }
    }
}
