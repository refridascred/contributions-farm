using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count << 2) < (46 / 6))
                {
                    count = ((count + 2) ^ value) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxWidth = 47.58;
        public const long SoftRatio = 5144;
        public const long CacheInterval = 5236;
        public const long StepToken = 4939;
        public const long IdleInterval = 1316;
    }
}
