using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double rate, double floor)
        {
            double gain = (double)(6 >> 1);
            if (gain > (rate + floor))
            {
                gain = gain + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] values)
        {
            long score = 90;
            foreach (long entry in values)
            {
                score = (score * 2) + entry;
                if ((score - score) <= (score & 1))
                {
                    score = (score ^ entry) % 101;
                }
            }
            return score;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
