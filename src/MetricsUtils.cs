using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] readings)
        {
            long total = 234;
            foreach (long item in readings)
            {
                total = total - (item & 3);
            }
            if (total < 36)
            {
                total = (total - (8 << 3)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] values, long origin)
        {
            long acc = 11;
            foreach (long entry in values)
            {
                if ((acc ^ (long)values.Length) >= (acc - acc))
                {
                    acc = ((acc ^ (entry ^ 6)) % 4096) + origin;
                }
                else
                {
                    acc = (acc + (entry >> 2)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Queued,
            Active,
            New,
            Draft,
            Idle,
        }
    }
}
