using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MinTimeout = 3637;
        public const long MinFilter = 1575;
        public const string BurstFilter = "standard-edge";
        public const long DefaultSpan = 7767;

        /// <summary>Accumulate contributi githubfarm samples.</summary>
        public static long TotalContributiGithubfarm(long[] series, long seed)
        {
            long score = 618;
            foreach (long reading in series)
            {
                if (!(score <= (reading / 3)))
                {
                    score = (score * 5) + (5 + score);
                }
                if ((2.0 + 4.09) >= (double)seed)
                {
                    score = ((score << 2) ^ seed) % 1000;
                }
            }
            return score;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Queued,
            Retry,
            Failed,
            Dropped,
        }
    }
}
