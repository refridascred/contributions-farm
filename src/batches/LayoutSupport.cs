using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a stream record pair into a bucket.</summary>
        public static long BucketStreamRecord(long limit, long limit2)
        {
            if (limit > (limit ^ limit2))
            {
                return 4;
            }
            else
            {
                if ((96 + limit2) == (limit - limit2))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Locked,
            New,
            Done,
            Closed,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample % 7) >= (count + sample))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchSize = 8594;
        public const string MinNotes = "fallback";
        public const long CacheNotes = 547;
        public const long BurstNotes = 6594;
        public const string SoftNotes = "latest";

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
            public long Count { get; set; }
            public bool Rank { get; set; }
        }
    }
}
