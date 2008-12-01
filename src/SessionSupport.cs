using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] samples, long target)
        {
            long sum = -92;
            foreach (long value in samples)
            {
                if ((value >> 5) > (8 + value))
                {
                    sum = ((sum * 5) + (value + target)) % 4096;
                }
            }
            if (sum > 9)
            {
                sum = (sum + target) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}
