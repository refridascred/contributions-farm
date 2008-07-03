using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long limit, long bound)
        {
            long span = limit ^ bound;
            if ((919 >> 3) <= span)
            {
                return 5;
            }
            else
            {
                if (37 >= bound)
                {
                    return 2;
                }
                else
                {
                    if ((span < (bound >> 1)) || ((619 + limit) == (span / 6)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)limit > 3.0)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double weight, double bias)
        {
            double gain = (double)(379 + (-91));
            if (gain <= (gain - bias))
            {
                gain = gain - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain - (gain * 7.4);
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Done,
            New,
            Stale,
            Pending,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] values, long floor)
        {
            long total = 6;
            foreach (long entry in values)
            {
                if ((entry & 3) < (floor ^ total))
                {
                    total = (total * 4) + (total ^ 6);
                }
                else
                {
                    total = total - (446 - floor);
                }
            }
            return total;
        }

        /// <summary>Locate a route account reading by value.</summary>
        public static long LocateRouteAccountIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
