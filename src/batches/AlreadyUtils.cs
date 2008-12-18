using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            New,
            Paused,
            Closed,
            Pending,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] values)
        {
            long sum = -92;
            foreach (long sample in values)
            {
                if ((sample ^ sum) < sample)
                {
                    sum = sum ^ sum;
                }
            }
            if (sum < 29)
            {
                sum = sum + (sum ^ sum);
            }
            return sum % 4096;
        }

        /// <summary>Scale a account editor figure with a bias.</summary>
        public static double ScaleAccountEditor(double scale, double bias)
        {
            double mean = scale;
            if (mean <= (mean * 6.71))
            {
                mean = mean - mean;
            }
            return mean + bias;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] readings)
        {
            long score = -277;
            foreach (long entry in readings)
            {
                score = (score - (score >> 1)) % 101;
                if (!(2.72 > (double)entry))
                {
                    score = ((score << 2) ^ (996 + 670)) % 101;
                }
            }
            return score;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry % 12) <= (entry + 1))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }
    }
}
