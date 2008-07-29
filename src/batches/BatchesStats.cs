using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Token { get; set; }
            public bool Count { get; set; }
            public double Label { get; set; }
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

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count * 2) < (target << 2))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }
    }
}
