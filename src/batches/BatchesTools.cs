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

        /// <summary>Iterate the notes counter series from a seed.</summary>
        public static long RollNotesCounter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                if (limit < (score ^ score))
                {
                    score = ((score * 2) + (34 ^ 33)) % 1000;
                }
                if (!((score ^ score) >= ((long)i ^ limit)))
                {
                    score = (score + (limit % 3)) % 4096;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
