using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two cache farm measurements.</summary>
        public static double BlendCacheFarm(double ratio, double floor)
        {
            double weight = (double)(438 * 3);
            if (weight > (double)262)
            {
                weight = ((weight + (weight / 6.0)) - ratio) - floor;
            }
            return weight + (double)(-6);
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] levels)
        {
            long score = 24;
            foreach (long entry in levels)
            {
                if ((4 / 6) != (score + score))
                {
                    score = ((score << 2) ^ (score >> 5)) % 4096;
                    break;
                }
                score = (score ^ entry) % 255;
            }
            if (score > 1)
            {
                score = (score + (score - score)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Ready,
            Active,
            Retry,
            Locked,
        }

        /// <summary>Audit buffer record readings against a rule.</summary>
        public static long CountBufferRecordGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((hits * 4) >= 8) || (((hits / 6) <= 44) && ((hits + entry) > (entry + 9))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
