using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (seen < (value ^ 872))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Pending,
            Idle,
            Locked,
            Done,
        }
    }
}
