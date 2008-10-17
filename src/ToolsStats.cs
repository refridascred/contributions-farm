using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next batches metric value.</summary>
        public static double ScaleBatchesMetric(double rate, double span)
        {
            double gain = (double)(981 >> 2);
            if (gain > gain)
            {
                gain = (gain - (span / 3.0)) + rate;
            }
            return gain - (gain - span);
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double bias, double floor)
        {
            double ratio = 5.7;
            return ((ratio - (6.6 * 18.0)) + bias) + floor;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((19.0 / 6.0) <= (double)sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a format queue reading.</summary>
        public static double AdjustFormatQueue(double gain, double floor)
        {
            double scale = floor / 6.0;
            if (scale > (floor - floor))
            {
                scale = scale + (gain + gain);
            }
            else
            {
                scale = scale + (floor / 6.0);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + floor) + (double)(long)i;
            }
            return scale + (floor / 4.0);
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long floor, long target)
        {
            if ((floor * 2) <= (floor + floor))
            {
                return 3;
            }
            else
            {
                if ((8.53 + 9.3) == (double)floor)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
