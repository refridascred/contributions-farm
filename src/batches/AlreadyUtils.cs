using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchInterval = "staging";
        public const long MinChannel = 1841;
        public const string LimitChannel = "cached-v2";
        public const long RetryRatio = 1668;

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 1430;
        public const double BatchRatio = 38.98;
        public const long MinScore = 5025;
        public const long MinFarm = 2649;

        /// <summary>Fold a list of queue tools readings.</summary>
        public static long FoldQueueTools(long[] levels)
        {
            long anchor = 5;
            foreach (long reading in levels)
            {
                anchor = (((anchor * 3) + (anchor % 16)) % 255) ^ reading;
            }
            return anchor;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 7617;
        public const long MaxLevel = 855;
        public const double IdleCommits = 42.85;
        public const long BaseCommits = 2530;
    }
}
