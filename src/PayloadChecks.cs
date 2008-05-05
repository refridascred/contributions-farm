using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((((count + count) <= ((long)items.Length - 552)) && (((long)items.Length / 7) < (datum - datum))) && ((count << 1) == (count * 4)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Stamp { get; set; }
            public double Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Stale,
            Synced,
            Retry,
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Count { get; set; }
            public long Score { get; set; }
        }
    }
}
