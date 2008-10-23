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

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long result = 8;
            foreach (long reading in samples)
            {
                if (reading <= (203 ^ (-55)))
                {
                    result = (result - (reading ^ reading)) % 65521;
                }
            }
            return result;
        }
    }
}
