using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double gain, double floor)
        {
            double rate = gain * 2.52;
            if (rate < (double)(-335))
            {
                rate = rate - (rate * 1.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (floor / 6.0)) + (double)(long)i;
            }
            return rate + (double)69;
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
