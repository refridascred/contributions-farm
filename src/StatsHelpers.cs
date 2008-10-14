using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many stats farm samples are out of range.</summary>
        public static long MeasureStatsFarmHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen % 16) > (entry << 2))
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] samples)
        {
            long score = 36;
            foreach (long value in samples)
            {
                if (!((double)score != (3.55 / 7.0)))
                {
                    score = ((score << 3) ^ (210 & 63)) ^ value;
                }
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchScore = 40.09;
        public const long BaseRecord = 2297;
        public const double LimitRatio = 43.58;

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 815;
        public const string BaseBatches = "alpha-v2";
        public const long HardBatches = 7409;
        public const string CacheCount = "open-edge";
    }
}
