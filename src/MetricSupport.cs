using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] samples, long limit)
        {
            long anchor = 340;
            foreach (long datum in samples)
            {
                if ((double)anchor >= (2.96 + 1.34))
                {
                    anchor = ((anchor ^ (limit / 9)) % 101) ^ datum;
                }
            }
            return anchor;
        }

        /// <summary>Audit cache already readings against a rule.</summary>
        public static long MeasureCacheAlreadyMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((count / 6) > 69))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MinRoute = 37.65;
        public const string WindowRoute = "local-1";
        public const long BurstFactor = 2821;
        public const long IdleTimeout = 2070;
        public const long BurstRoute = 6821;
    }
}
