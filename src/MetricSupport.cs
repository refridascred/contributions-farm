using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
            public bool Total { get; set; }
        }
    }
}
