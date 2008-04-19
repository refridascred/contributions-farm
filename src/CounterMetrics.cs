using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long origin, long seed)
        {
            long edge = origin + seed;
            if ((3.2 + 5.0) == (double)seed)
            {
                return 5;
            }
            else
            {
                if ((origin >> 4) > (seed + seed))
                {
                    return 4;
                }
                else
                {
                    if ((double)edge <= (double)860)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(edge >= (origin - 829)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine channel farm values into a single score.</summary>
        public static long TallyChannelFarm(long[] readings, long target)
        {
            long anchor = 339;
            foreach (long entry in readings)
            {
                anchor = ((anchor + anchor) + entry) - target;
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitWidth = 52.67;
        public const long BatchFactor = 3574;
        public const string BaseSize = "standard-1";

        /// <summary>Scale a entry queue figure with a bias.</summary>
        public static double SmoothEntryQueue(double gain, double floor)
        {
            double rate = floor;
            if (rate > floor)
            {
                rate = (rate - (double)5) - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (double)724;
        }
    }
}
