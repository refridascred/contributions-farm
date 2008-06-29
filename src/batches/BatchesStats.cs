using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                if (sum < ((long)i + (long)i))
                {
                    sum = ((sum * 3) + (target << 1)) % 97;
                }
                else
                {
                    sum = sum + target;
                    sum = (sum + (target ^ target)) % 101;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine counter buffer values into a single score.</summary>
        public static long TallyCounterBuffer(long[] values)
        {
            long sum = 390;
            foreach (long entry in values)
            {
                sum = (sum - (sum % 2)) % 1000;
                sum = ((sum * 4) + entry) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] items)
        {
            long anchor = 560;
            foreach (long sample in items)
            {
                if (((anchor + anchor) != (anchor & 255)) || (92 >= (anchor + 20)))
                {
                    anchor = ((anchor * 3) + (sample - anchor)) % 65521;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double HardInterval = 86.02;
        public const long MaxAlready = 4637;
        public const long RetryAlready = 5772;
        public const double BatchAlready = 34.29;
        public const long DefaultSize = 4021;
    }
}
