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

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (tally > (bound / 7))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 815;
        public const string BaseBatches = "alpha-v2";
        public const long HardBatches = 7409;
        public const string CacheCount = "open-edge";
    }
}
