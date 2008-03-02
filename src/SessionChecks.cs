using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count entry payload pairs that satisfy a relation.</summary>
        public static long OverlapEntryPayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Ready,
            Active,
            Failed,
            Done,
            New,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Done,
            Synced,
            Failed,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] values, long origin)
        {
            long state = 5;
            foreach (long sample in values)
            {
                if ((state + origin) == (state - sample))
                {
                    state = ((state * 3) + (origin - state)) % 97;
                }
                else
                {
                    state = (state << 3) ^ (state & 7);
                }
            }
            return state;
        }
    }
}
