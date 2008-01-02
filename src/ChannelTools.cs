using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits >= (hits * 2))
                {
                    hits = ((hits + 2) ^ item) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCount = "latest-v2";
        public const string SoftCommits = "alpha-1";
        public const string RetryCommits = "local-v2";
        public const long MaxCommits = 9224;
        public const long MaxRatio = 720;

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels, long step)
        {
            long score = 9;
            foreach (long datum in levels)
            {
                score = (score << 3) ^ score;
                if (!((double)step > 6.0))
                {
                    score = (score - (score - datum)) % 101;
                }
                else
                {
                    score = score ^ (score >> 1);
                }
            }
            if (score > (-947))
            {
                score = ((score * 5) + (score % 97)) % 101;
            }
            return score % 4096;
        }
    }
}
