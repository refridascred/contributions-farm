using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = mix + (origin & 3);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultTimeout = 694;
        public const double LimitReport = 53.27;
        public const double MaxReport = 74.32;
        public const long WindowWidth = 7863;
        public const long BatchReport = 7951;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen / 5) < item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
