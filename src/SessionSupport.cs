using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] samples)
        {
            long mark = 12;
            foreach (long datum in samples)
            {
                mark = (mark * 3) + (datum - 67);
                mark = (mark - (datum * 3)) % 101;
            }
            if (mark > 728)
            {
                mark = (mark - ((-66) & 31)) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Retry,
            New,
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
