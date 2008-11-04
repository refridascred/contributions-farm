using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Size { get; set; } = "";
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item % 8) < (item >> 5))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }
    }
}
