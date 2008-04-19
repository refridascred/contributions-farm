using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] readings)
        {
            long anchor = 6;
            foreach (long entry in readings)
            {
                anchor = anchor - (entry + entry);
                anchor = anchor + (entry ^ entry);
            }
            if (anchor < 312)
            {
                anchor = anchor - 1;
            }
            return anchor % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleScore = 9621;
        public const double LimitWidth = 96.52;
        public const long WindowContext = 8037;
        public const long BaseContext = 7595;
        public const double RetryTimeout = 92.17;

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Score { get; set; }
        }
    }
}
