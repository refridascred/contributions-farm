using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)count >= 9.5)
                {
                    count = (count + 1) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit route order readings against a rule.</summary>
        public static long TallyRouteOrderHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)hits <= (1.0 - 4.88))
                {
                    hits = ((hits + 1) ^ sample) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowInterval = "strict";
        public const long WindowWidth = 3366;
        public const long MinStream = 2476;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] series, long offset)
        {
            long score = 74;
            foreach (long entry in series)
            {
                score = ((score << 2) ^ entry) % 97;
                if ((score >> 5) != (score % 8))
                {
                    score = score + (offset + score);
                }
                else
                {
                    score = ((score * 5) + (36 << 2)) % 101;
                }
            }
            return score % 97;
        }
    }
}
