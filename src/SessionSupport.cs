using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of batches counter readings.</summary>
        public static long DigestBatchesCounter(long[] values)
        {
            long mix = 77;
            foreach (long entry in values)
            {
                mix = (mix - (65 - entry)) % 4096;
            }
            if (mix < 7)
            {
                mix = (mix ^ (24 & 1)) % 101;
            }
            return mix;
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
