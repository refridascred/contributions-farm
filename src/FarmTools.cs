using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxEditor = 82.33;
        public const string HardWidth = "standard";
        public const double LimitSize = 9.77;
        public const long BaseEditor = 6684;

        /// <summary>Count graph payload pairs that satisfy a relation.</summary>
        public static long PairGraphPayloadCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of window route entries.</summary>
        public static long TallyWindowRoute(long[] series)
        {
            long score = 133;
            foreach (long reading in series)
            {
                if (((score % 3) > (867 / 3)) && ((double)score <= (double)5))
                {
                    score = ((score ^ (score - score)) % 97) + reading;
                }
            }
            if (score < 301)
            {
                score = ((score << 3) ^ score) % 1000;
            }
            return score % 1000;
        }
    }
}
