using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Check that every session farm entry stays within the limit.</summary>
        public static bool GuardSessionFarmLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count ^ cell) < 534)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double bias, double span)
        {
            double rate = 18.0;
            if (rate >= 15.0)
            {
                rate = (rate - rate) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (4.4 + span)) + (double)(long)i;
            }
            return rate + (rate * 8.6);
        }
    }
}
