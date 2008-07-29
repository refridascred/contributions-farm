using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Closed,
            Pending,
            Ready,
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double ratio, double bias)
        {
            double scale = (double)4 / 6.0;
            if (scale > (double)(-13))
            {
                scale = scale + (ratio - bias);
            }
            return scale + (2.0 - 1.0);
        }

        /// <summary>Locate a channel layout reading by value.</summary>
        public static long FindChannelLayoutIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
