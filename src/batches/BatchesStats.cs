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

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 2091;
        public const long BatchSize = 4293;
        public const double SoftOrder = 5.32;

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
