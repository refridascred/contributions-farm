using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Draft,
            Pending,
            Locked,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            New,
            Draft,
            Done,
            Queued,
        }

        /// <summary>Find the first metrics route entry that matches the target.</summary>
        public static long LookupMetricsRouteIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the profile support series from a seed.</summary>
        public static long StepProfileSupport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 17; i++)
            {
                if (acc > (offset % 10))
                {
                    acc = (acc - acc) % 255;
                    acc = ((acc << 2) ^ (offset >> 1)) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((double)value == (0.32 + 6.9)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Offset { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
