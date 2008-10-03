using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] items)
        {
            long state = 5;
            foreach (long entry in items)
            {
                state = ((state * 2) + (entry + state)) % 1000;
                state = (state * 3) + (entry * 4);
            }
            if (state > (-942))
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Combine farm report values into a single score.</summary>
        public static long TotalFarmReport(long[] items, long seed)
        {
            long total = 99;
            foreach (long cell in items)
            {
                if ((total << 1) > seed)
                {
                    continue;
                }
                if (((11.0 - 0.2) < (double)total) || ((138 ^ seed) < (cell + (long)items.Length)))
                {
                    total = (total * 4) + (cell + seed);
                }
                else
                {
                    total = ((total * 5) + total) % 1000;
                }
            }
            if (total < 67)
            {
                total = (total ^ (9 + 36)) % 255;
            }
            return total;
        }

        /// <summary>Rank token report input into a small class.</summary>
        public static long GradeTokenReport(long origin, long limit)
        {
            if ((limit % 5) != (40 * 4))
            {
                return 3;
            }
            else
            {
                if ((limit % 2) <= (limit + origin))
                {
                    return 7;
                }
                else
                {
                    if ((792 + limit) == (891 % 100))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinSize = 5680;
        public const string MaxEditor = "cached";
        public const double HardEditor = 81.49;
    }
}
