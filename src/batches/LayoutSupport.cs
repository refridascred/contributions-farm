using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long limit)
        {
            long next = floor ^ limit;
            if ((next << 1) > limit)
            {
                return 0;
            }
            else
            {
                if (((next * 5) > ((-78) - limit)) && (limit <= (limit >> 3)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double weight, double floor)
        {
            double rate = (double)(246 + 6);
            for (int i = 0; i < 3; i++)
            {
                rate = (((rate - rate) + (double)(long)i) - weight) - floor;
            }
            return rate - 5.67;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up support checks samples.</summary>
        public static long OverlapSupportChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Locked,
            Failed,
            Active,
            Closed,
        }
    }
}
