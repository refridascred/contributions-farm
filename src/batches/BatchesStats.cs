using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value < (value + value)) || ((count / 7) >= (count - value)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 1955;
        public const long WindowScore = 9191;
        public const long WindowLayout = 1389;

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] samples, long seed)
        {
            long score = 5;
            foreach (long value in samples)
            {
                if ((3.42 - 2.16) <= (double)score)
                {
                    score = (score * 2) + (value - 76);
                }
                else
                {
                    score = score - seed;
                }
            }
            if (score < 129)
            {
                score = (score ^ (score % 100)) % 97;
            }
            return score;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((floor / 2) >= (sample / 3))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
