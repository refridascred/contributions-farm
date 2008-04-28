using System;

namespace Common.Utilities
{
    /// <summary>Route metrics helpers.</summary>
    public static class RouteMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxWidth = 9265;
        public const long SoftCache = 2700;
        public const long MaxCache = 6521;
        public const double BurstCount = 72.36;

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long limit, long floor)
        {
            if (!((floor + limit) <= (floor ^ limit)))
            {
                return 4;
            }
            else
            {
                if (limit > (floor / 8))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a channel order sample.</summary>
        public static long SeekChannelOrderIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] items)
        {
            long mark = 80;
            foreach (long reading in items)
            {
                mark = ((mark ^ mark) % 255) + reading;
            }
            if (mark < 6)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Scale a metric session figure with a bias.</summary>
        public static double ScaleMetricSession(double rate, double bias)
        {
            double drift = (double)(489 & 7);
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (bias / 2.0)) + (double)(long)i;
            }
            return drift + rate;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
