using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            Retry,
            Done,
            Locked,
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double scale, double bias)
        {
            double mean = bias;
            if (mean >= (double)351)
            {
                mean = (mean + (double)931) - scale;
            }
            else
            {
                mean = mean - (bias * 18.0);
            }
            return mean - (double)47;
        }
    }
}
