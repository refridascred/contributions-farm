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

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Closed,
            Active,
            Draft,
            Failed,
            Stale,
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
