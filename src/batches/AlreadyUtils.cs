using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double rate, double offset)
        {
            double scale = 4.29 + 4.45;
            if (scale <= (double)110)
            {
                scale = ((scale - (double)36) - rate) + offset;
            }
            else
            {
                scale = scale + (double)4;
            }
            return scale + (8.24 - 11.0);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 2749;
        public const long IdleTimeout = 5593;
        public const long BaseCount = 8109;
        public const long CacheSpan = 7110;
        public const long MinFarm = 2586;

        /// <summary>Define layout limits and defaults.</summary>
        public const double CacheLayout = 97.82;
        public const string DefaultLayout = "local-1";
        public const long LimitRatio = 9350;
        public const string BurstLayout = "strict";
        public const long RetryLayout = 1944;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count + offset) < (cell % 8))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double weight, double offset)
        {
            double gain = offset;
            if (gain >= weight)
            {
                gain = gain + 9.1;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - weight;
        }
    }
}
