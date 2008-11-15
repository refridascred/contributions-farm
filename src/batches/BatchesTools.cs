using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 6972;
        public const long RetryRatio = 6102;
        public const long DefaultEditor = 8140;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                total = (total + ((long)i << 3)) % 255;
                if ((double)total != (5.63 + 5.77))
                {
                    total = total + (total % 60);
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Iterate the notes entry series from a seed.</summary>
        public static long StepNotesEntry(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((state / 9) >= (bound ^ (long)i))
                {
                    state = state + (bound / 8);
                }
                else
                {
                    state = ((state << 3) ^ state) % 97;
                    state = state - (bound >> 4);
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = ((state * 4) + (state >> 3)) - (long)i2;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
