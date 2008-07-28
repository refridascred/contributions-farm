using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 5) + (limit << 2)) % 97;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
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
