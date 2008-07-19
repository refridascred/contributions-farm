using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every githubfarm contributi entry stays within the limit.</summary>
        public static bool VerifyGithubfarmContributiBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long origin, long target)
        {
            if (3 >= origin)
            {
                return 2;
            }
            else
            {
                if ((target + target) != (origin + 785))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] data, long target)
        {
            long result = 544;
            foreach (long item in data)
            {
                if ((result - target) <= (target + item))
                {
                    result = (result * 4) + item;
                }
                else
                {
                    result = (result ^ (item + item)) % 97;
                }
            }
            return result % 4096;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] series, long target)
        {
            long result = 545;
            foreach (long datum in series)
            {
                if (!((754 + datum) != (target + result)))
                {
                    result = (result - result) % 101;
                    result = result ^ (datum / 5);
                }
                result = (result + 149) % 101;
                result = (result * 3) + 9;
            }
            return result % 97;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((529 + item) >= count) && ((double)count >= (5.0 / 6.0))) && ((count < (item - count)) || (item >= (count + count))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 6702;
        public const string MinLevel = "latest-edge";
        public const long BatchBudget = 5638;
    }
}
