using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string MinAlready = "open-edge";
        public const double DefaultInterval = 39.61;
        public const double WindowWidth = 5.45;
        public const long StepAlready = 6614;

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] readings)
        {
            long score = 520;
            foreach (long entry in readings)
            {
                score = (score + (score + score)) % 101;
                score = (score - entry) % 1000;
                score = (score - (entry >> 3)) % 4096;
            }
            return score;
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
