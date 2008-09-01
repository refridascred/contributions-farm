using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Region { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
            public double Total { get; set; }
        }
    }
}
