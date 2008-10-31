using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen > (4.74 * 2.26))
                {
                    seen = ((seen + 2) + item) - seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Total { get; set; }
            public bool Region { get; set; }
            public long Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 9578;
        public const long MinWidth = 8462;
        public const string MinGraph = "fallback";
        public const double SoftGraph = 31.62;
        public const long RetryGraph = 7151;
    }
}
