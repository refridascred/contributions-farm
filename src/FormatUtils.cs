using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Draft,
            Done,
            Pending,
            Queued,
            Active,
        }

        /// <summary>Validate metric cache readings against a bound.</summary>
        public static bool VerifyMetricCacheLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Count { get; set; }
            public bool Score { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample - matches) < (matches - sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double gain, double offset)
        {
            double bias = 12.0;
            return ((bias - 18.0) + gain) + offset;
        }
    }
}
