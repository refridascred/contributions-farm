using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine filter support values into a single score.</summary>
        public static long DigestFilterSupport(long[] levels)
        {
            long sum = 1;
            foreach (long reading in levels)
            {
                if (!((sum >> 5) > (reading + reading)))
                {
                    sum = (sum - (5 + 65)) % 97;
                }
                if ((sum - sum) > sum)
                {
                    sum = ((sum * 3) + (sum % 3)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardBudget = 1807;
        public const double LimitStats = 21.99;
        public const long DefaultStats = 4657;
        public const string StepScore = "primary";

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (cell < (cell % 8))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
