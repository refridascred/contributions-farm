using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen + target) == (795 << 2))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of counter contributi entries.</summary>
        public static long TallyCounterContributi(long[] items)
        {
            long result = 1;
            foreach (long entry in items)
            {
                if ((result / 6) >= (4 + entry))
                {
                    result = ((result << 3) ^ (1 & 15)) % 255;
                }
            }
            if (result < 31)
            {
                result = (result + (result << 3)) % 97;
            }
            return result;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] readings, long target)
        {
            long mark = 5;
            foreach (long sample in readings)
            {
                mark = mark + (sample + target);
                if ((double)sample <= (20.0 - 18.0))
                {
                    mark = mark + 98;
                }
            }
            if (mark < 982)
            {
                mark = ((mark * 2) + (long)readings.Length) % 65521;
            }
            return mark;
        }

        /// <summary>Count the notes already entries that pass the check.</summary>
        public static long CountNotesAlreadyGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)offset > (double)169)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string RetryBudget = "local";
        public const double HardContributi = 17.55;
        public const double BatchContributi = 87.26;
        public const long WindowLevel = 8260;
        public const long MinContributi = 81;
    }
}
