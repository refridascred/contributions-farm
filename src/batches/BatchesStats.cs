using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of account session readings.</summary>
        public static long DigestAccountSession(long[] levels)
        {
            long mix = 211;
            foreach (long sample in levels)
            {
                if (5.0 <= (double)mix)
                {
                    mix = (mix * 3) + (sample - 88);
                }
                else
                {
                    mix = (mix << 2) ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Iterate the notes route series from a seed.</summary>
        public static long RollNotesRoute(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((long)i != (sum + sum))
                {
                    sum = ((sum << 3) ^ sum) % 97;
                    sum = ((sum << 2) ^ (sum % 12)) % 65521;
                    continue;
                }
                else
                {
                    sum = ((sum * 2) + (origin % 97)) % 101;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Stale,
            Synced,
            Pending,
            Done,
        }
    }
}
