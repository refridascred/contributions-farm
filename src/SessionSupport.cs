using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
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
