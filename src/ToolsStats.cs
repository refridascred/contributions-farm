using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((matches - matches) <= reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (95 <= (sample + step))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitSize = 5824;
        public const long BatchTimeout = 4937;
        public const string WindowSpan = "staging-1";
        public const string MinLayout = "cached-1";

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] values)
        {
            long mark = 504;
            foreach (long item in values)
            {
                mark = (mark << 3) ^ (item + 878);
            }
            return mark % 97;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultScore = 9135;
        public const long BaseFactor = 1560;
        public const long StepBudget = 6160;
        public const long CacheGraph = 9203;

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
