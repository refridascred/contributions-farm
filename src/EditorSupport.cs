using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next stats tools value from a seed.</summary>
        public static long SeriesStatsTools(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = (((carry << 2) ^ ((-3) + carry)) % 65521) + (long)i2;
                    carry = carry - (carry + offset);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 5966;
        public const long CacheCount = 6477;
        public const long MinChecks = 8069;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Active,
            Retry,
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Locked,
            Draft,
            Dropped,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values)
        {
            long state = 17;
            foreach (long entry in values)
            {
                if (!((state ^ entry) <= (entry ^ entry)))
                {
                    state = (state + state) % 255;
                }
            }
            return state;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] values, long seed)
        {
            long score = 845;
            foreach (long value in values)
            {
                if ((score << 3) < (seed * 5))
                {
                    score = (score + (82 - value)) % 4096;
                }
            }
            return score;
        }
    }
}
