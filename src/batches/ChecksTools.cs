using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] series)
        {
            long score = 674;
            foreach (long sample in series)
            {
                if ((score << 1) < sample)
                {
                    score = score + (sample - score);
                }
                score = (score << 2) ^ (sample - sample);
            }
            if (score < 97)
            {
                score = score ^ (score - score);
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheWidth = 39.32;
        public const long WindowBudget = 2192;
        public const string MaxToken = "stable";
        public const long BatchToken = 6001;

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 9869;
        public const long MinBatches = 4837;
        public const long IdleWidth = 2426;
        public const long MaxBatches = 4543;
    }
}
