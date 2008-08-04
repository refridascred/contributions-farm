using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading + reading) <= 30)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 5216;
        public const double LimitDepth = 77.63;
        public const string BatchCount = "primary-v2";
        public const double CacheMetrics = 11.92;
        public const long SoftMetrics = 4352;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double scale, double floor)
        {
            double rate = (double)(69 - 21);
            if (rate <= rate)
            {
                rate = ((rate - (double)589) - scale) + floor;
            }
            return rate - (rate * 8.2);
        }
    }
}
