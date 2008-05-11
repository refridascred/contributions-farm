using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 >= (double)756)
            {
                weight2 = (weight2 + (bias * 4.0)) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 - (double)(-789)) + (double)(long)i;
            }
            return weight2 + bias;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long origin, long floor)
        {
            long span = origin - floor;
            if ((841 & 63) > span)
            {
                return 3;
            }
            else
            {
                if ((origin + floor) <= (span ^ origin))
                {
                    return 1;
                }
                else
                {
                    if (origin > (origin >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Pending,
            Paused,
            Locked,
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
