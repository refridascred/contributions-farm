using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string MinRatio = "primary-v2";
        public const long HardAlready = 2737;
        public const string BaseAlready = "primary-1";
        public const long BurstFactor = 2707;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((((item - offset) > (offset + 755)) && ((3.78 - 3.33) != (double)offset)) || ((long)readings.Length < (item << 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] series)
        {
            long score = -725;
            foreach (long item in series)
            {
                if ((double)score != (3.0 - 1.0))
                {
                    score = score + (item % 64);
                }
            }
            if (score > 888)
            {
                score = score - (score + 618);
            }
            return score % 97;
        }
    }
}
