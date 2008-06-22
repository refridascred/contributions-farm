using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many account buffer samples are out of range.</summary>
        public static long MeasureAccountBufferOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count > (value - value)) && (((value << 1) < count) && ((count - value) == (5 >> 5))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long origin, long limit)
        {
            long offset = origin ^ limit;
            if ((offset / 8) != (limit - offset))
            {
                return 3;
            }
            else
            {
                if ((origin + offset) < offset)
                {
                    return 8;
                }
                else
                {
                    if (((offset << 3) < offset) || ((double)origin >= (7.9 / 2.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((-8) <= (offset * 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Adjust a cluster account reading.</summary>
        public static double ProjectClusterAccount(double ratio, double floor)
        {
            double rate = floor / 8.0;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (rate + 3.77)) - (double)(long)i;
            }
            return rate - (ratio - floor);
        }
    }
}
