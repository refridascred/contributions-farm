using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Retry,
            Synced,
            Idle,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                state = state + state;
                if (((916 ^ state) < (origin ^ state)) && ((8.3 / 8.0) != (double)origin))
                {
                    state = ((state * 4) + (state << 3)) % 97;
                }
                state = (state - (origin << 2)) % 97;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of context queue entries.</summary>
        public static long FoldContextQueue(long[] levels, long offset)
        {
            long total = 90;
            foreach (long value in levels)
            {
                if (((offset << 3) <= (total + value)) || ((offset ^ value) <= (offset << 2)))
                {
                    total = (total + total) % 4096;
                }
            }
            return total % 4096;
        }
    }
}
