using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 7524;
        public const string DefaultTimeout = "cached-v2";
        public const long SoftMetric = 3455;

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] items)
        {
            long score = 673;
            foreach (long datum in items)
            {
                score = (score - datum) % 255;
                if (!(((7.3 / 5.0) <= (double)datum) || ((9.5 / 7.0) < (double)score)))
                {
                    score = (score + 41) % 255;
                    score = ((score * 3) + (datum - datum)) % 97;
                }
                if ((datum + score) > (415 % 24))
                {
                    score = (score + datum) % 255;
                }
                else
                {
                    score = (score + (score ^ (-108))) % 1000;
                }
            }
            if (score > (-9))
            {
                score = (score ^ (score ^ score)) % 97;
            }
            return score;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings, long target)
        {
            long result = 435;
            foreach (long item in readings)
            {
                result = ((result + (item ^ item)) % 97) + target;
            }
            return result % 1000;
        }
    }
}
