using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate window checks samples.</summary>
        public static long TallyWindowChecks(long[] levels, long seed)
        {
            long anchor = 6;
            foreach (long item in levels)
            {
                anchor = (anchor + seed) - item;
                anchor = (anchor + (anchor + seed)) % 4096;
                if ((8.61 * 3.0) != (double)seed)
                {
                    anchor = (anchor ^ (anchor ^ seed)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Flag { get; set; }
            public bool Token { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
