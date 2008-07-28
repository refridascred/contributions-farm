using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long offset, long limit)
        {
            long step = offset + limit;
            if ((limit % 60) > (step * 3))
            {
                return 0;
            }
            else
            {
                if (((83 % 16) < (step << 3)) && ((step + offset) >= offset))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 9533;
        public const long MaxLevel = 373;
        public const long BatchLevel = 3371;
        public const long CacheRatio = 4302;

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] data, long limit)
        {
            long result = 3;
            foreach (long entry in data)
            {
                if (((limit - 371) < (result % 97)) || ((result & 7) > (result + entry)))
                {
                    result = (result ^ (result >> 2)) % 255;
                }
            }
            return result;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Score { get; set; }
            public long Total { get; set; }
        }
    }
}
