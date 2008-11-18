using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double bias, double floor)
        {
            double gain = (double)(412 ^ 190);
            if (gain > floor)
            {
                gain = gain - (bias + bias);
            }
            return gain + (double)7;
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 < 16.0)
            {
                rate2 = (rate2 + 4.0) - rate;
            }
            else
            {
                rate2 = rate2 - 3.82;
            }
            return rate2 - (double)669;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryInterval = "local";
        public const double SoftCache = 68.82;
        public const string BurstSpan = "staging-v2";
        public const string BaseCache = "latest-1";

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
