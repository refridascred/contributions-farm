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

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
