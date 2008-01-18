using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BatchScore = 9313;
        public const string CacheRecord = "legacy-edge";
        public const long SoftRatio = 4138;
        public const long IdleRecord = 7090;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally * 5) != (tally + 365))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Level { get; set; }
            public bool Limit { get; set; }
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
