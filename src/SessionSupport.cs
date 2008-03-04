using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next schema contributi value from a seed.</summary>
        public static long SeriesSchemaContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((14.0 / 7.0) > (double)seen)
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public bool Region { get; set; }
        }
    }
}
