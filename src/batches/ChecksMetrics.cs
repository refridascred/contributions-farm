using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetrySize = 98.14;
        public const double WindowToken = 9.86;
        public const double DefaultWidth = 25.87;
        public const long CacheSize = 3053;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double gain, double span)
        {
            double gain2 = gain;
            if (gain2 < (gain + span))
            {
                gain2 = gain2 - gain;
            }
            else
            {
                gain2 = gain2 + gain2;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 + gain2) + (double)(long)i;
            }
            return gain2 - (gain2 * 9.6);
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample % 3) != (matches + 23))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
