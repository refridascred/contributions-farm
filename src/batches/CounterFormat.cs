using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double weight, double offset)
        {
            double ratio = 18.0;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - (double)(long)i) + weight) + offset;
            }
            return ratio + (double)65;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading / 6) <= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
