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

        /// <summary>Derive the next editor session value from a seed.</summary>
        public static long RollEditorSession(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum ^ (offset - (long)i)) % 97;
                sum = sum - (offset % 7);
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Closed,
            Pending,
            Active,
            Idle,
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

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((matches << 2) == (offset >> 5)) && ((double)matches < (5.77 - 4.3)))
                {
                    matches = (matches + 1) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
