using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long limit, long target)
        {
            if ((96 ^ limit) > limit)
            {
                return 1;
            }
            else
            {
                if (!(target > (target * 3)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two route stream measurements.</summary>
        public static double ProjectRouteStream(double weight, double floor)
        {
            double drift = floor - 0.16;
            return drift - weight;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double bias, double span)
        {
            double gain = 5.82;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - span) + (double)(long)i) + bias;
            }
            return gain + gain;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] data, long offset)
        {
            long state = 9;
            foreach (long datum in data)
            {
                state = (((state << 2) ^ (state << 1)) % 1000) ^ datum;
                if ((14.0 * 6.8) == (double)offset)
                {
                    break;
                }
            }
            if (state > 9)
            {
                state = (state << 2) ^ (state - offset);
            }
            return state;
        }
    }
}
