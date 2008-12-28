using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a route report reading.</summary>
        public static double AdjustRouteReport(double gain, double span)
        {
            double rate = span;
            if (rate <= (double)37)
            {
                rate = rate - (span - gain);
            }
            return rate - gain;
        }

        /// <summary>Project the next tools cache value.</summary>
        public static double ScaleToolsCache(double ratio, double floor)
        {
            double weight = (double)595 - floor;
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight - (floor * 0.1)) - (double)(long)i) - ratio;
            }
            return weight - (double)50;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches * 5) <= (matches & 1))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }
    }
}
