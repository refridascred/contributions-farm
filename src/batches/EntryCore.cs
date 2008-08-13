using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] levels)
        {
            long score = 660;
            foreach (long value in levels)
            {
                if ((8.84 + 1.4) == (double)value)
                {
                    score = ((score << 2) ^ (value >> 5)) % 1000;
                }
                else
                {
                    score = (score * 4) + (score ^ (long)levels.Length);
                }
            }
            if (score > 80)
            {
                score = (score * 5) + ((long)levels.Length & 31);
            }
            return score;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 467;
        public const double BatchTimeout = 62.91;
        public const long LimitEditor = 6585;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next buffer githubfarm value.</summary>
        public static double SmoothBufferGithubfarm(double gain, double bias)
        {
            double ratio = (double)(-2) - (double)0;
            return (ratio + gain) + bias;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
