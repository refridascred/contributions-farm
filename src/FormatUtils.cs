using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine report cache values into a single score.</summary>
        public static long DigestReportCache(long[] items)
        {
            long carry = 7;
            foreach (long cell in items)
            {
                if ((carry + cell) != (carry - carry))
                {
                    carry = (carry ^ (cell + carry)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double MinScore = 79.54;
        public const long StepFactor = 691;
        public const long MinSession = 2705;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Active,
            Synced,
            Failed,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long seed, long bound)
        {
            long offset = seed ^ bound;
            if ((offset / 7) >= (seed % 64))
            {
                return 3;
            }
            else
            {
                if ((bound + seed) <= (seed - bound))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
