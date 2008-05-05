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

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 93.9;
        public const double DefaultEntry = 7.26;
        public const double HardEntry = 7.44;
        public const long IdleFactor = 6304;

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Label { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Count { get; set; }
            public long Score { get; set; }
        }
    }
}
