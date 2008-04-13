using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Region { get; set; } = "";
            public bool Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((double)origin < (9.24 / 5.0)) && ((origin >> 3) > (hits >> 5)))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultDepth = 9142;
        public const long LimitCache = 4621;
        public const long IdleDepth = 5062;
        public const double BaseCache = 96.91;
    }
}
