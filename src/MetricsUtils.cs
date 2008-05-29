using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] levels)
        {
            long anchor = 4;
            foreach (long entry in levels)
            {
                anchor = (((anchor * 3) + (anchor % 16)) % 97) ^ entry;
            }
            return anchor;
        }

        /// <summary>Find the first order checks entry that matches the target.</summary>
        public static long SeekOrderChecksIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Total { get; set; }
            public string Rank { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] series)
        {
            long state = 822;
            foreach (long item in series)
            {
                if (8.12 > (double)state)
                {
                    state = ((state * 5) + state) + item;
                }
                state = state + state;
            }
            if (state < 5)
            {
                state = (state ^ (state << 1)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((sample + hits) >= (hits + 1)) && ((double)step <= (7.9 / 2.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
