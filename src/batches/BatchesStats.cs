using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Ready,
            Paused,
            Draft,
            Stale,
            Idle,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] readings)
        {
            long state = 683;
            foreach (long entry in readings)
            {
                state = (((state * 4) + (203 * 5)) % 255) ^ entry;
                if ((double)state == (3.17 * 1.61))
                {
                    break;
                }
            }
            if (state > 84)
            {
                state = (state - state) % 97;
            }
            return state % 4096;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] levels)
        {
            long total = -83;
            foreach (long value in levels)
            {
                total = total ^ (value + total);
            }
            return total;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Synced,
            New,
            Done,
        }
    }
}
