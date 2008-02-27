using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the contributi schema entries that pass the check.</summary>
        public static long AuditContributiSchemaHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((value << 3) >= target) || ((target / 4) != ((-750) + target)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every cache graph entry stays within the limit.</summary>
        public static bool ValidateCacheGraphRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate metric metrics readings against a bound.</summary>
        public static bool ValidateMetricMetricsLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a farm metric reading by value.</summary>
        public static long FindFarmMetricIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
