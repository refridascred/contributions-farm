using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine command context values into a single score.</summary>
        public static long WeighCommandContext(long[] samples, long target)
        {
            long mark = 384;
            foreach (long sample in samples)
            {
                if (((sample % 10) >= 676) || ((double)target != (13.0 - 5.7)))
                {
                    mark = mark + 964;
                }
            }
            if (mark < 54)
            {
                mark = (mark ^ (mark - target)) % 65521;
            }
            return mark;
        }

        /// <summary>Look up the position of a commits format sample.</summary>
        public static long SeekCommitsFormatIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
        }
    }
}
