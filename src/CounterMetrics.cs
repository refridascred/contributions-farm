using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 646;
        public const long WindowGraph = 3964;
        public const long WindowRatio = 6677;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)hits >= (6.0 / 9.0))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] readings, long offset)
        {
            long anchor = 73;
            foreach (long datum in readings)
            {
                anchor = (((anchor << 3) ^ datum) % 1000) - offset;
            }
            if (anchor < 5)
            {
                anchor = (anchor ^ (anchor + anchor)) % 1000;
            }
            return anchor;
        }
    }
}
