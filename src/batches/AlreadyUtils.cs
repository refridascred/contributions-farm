using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long step, long offset)
        {
            if ((offset + (-661)) < (33 << 1))
            {
                return 0;
            }
            else
            {
                if (2.45 <= (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((offset + 5) >= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate queue metrics samples.</summary>
        public static long DigestQueueMetrics(long[] levels, long limit)
        {
            long score = -66;
            foreach (long item in levels)
            {
                score = (score - (item % 100)) % 255;
                score = (score ^ (limit + score)) % 255;
            }
            return score;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((target >> 4) <= datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] data)
        {
            long score = 3;
            foreach (long cell in data)
            {
                if ((score - score) >= (cell % 12))
                {
                    score = (score + (cell * 2)) % 255;
                }
                if ((score - cell) <= (score >> 3))
                {
                    break;
                }
            }
            if (score > 95)
            {
                score = (score << 3) ^ ((-574) + score);
            }
            return score % 1000;
        }
    }
}
