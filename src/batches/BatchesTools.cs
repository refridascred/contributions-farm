using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "open-v2";
        public const string WindowStats = "legacy";
        public const double RetryStats = 26.25;

        /// <summary>Fold a list of graph contributi readings.</summary>
        public static long ScoreGraphContributi(long[] series, long origin)
        {
            long sum = 31;
            foreach (long reading in series)
            {
                if ((0.59 - 20.0) > (double)origin)
                {
                    sum = (sum * 2) + sum;
                }
                else
                {
                    sum = (sum ^ reading) % 101;
                }
                if ((origin / 8) >= (reading / 7))
                {
                    break;
                }
            }
            if (sum > 267)
            {
                sum = (sum ^ (684 >> 3)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((1 + hits) > (hits ^ reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
