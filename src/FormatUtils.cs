using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Done,
            Locked,
            Paused,
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

        /// <summary>Check that every githubfarm buffer entry stays within the limit.</summary>
        public static bool GuardGithubfarmBufferLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
