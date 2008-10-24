using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Label { get; set; }
            public bool Count { get; set; }
            public double Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!(18.0 < (double)matches))
                {
                    matches = (matches + 1) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
