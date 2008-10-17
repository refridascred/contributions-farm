using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a entry graph pair into a bucket.</summary>
        public static long SortEntryGraph(long bound, long origin)
        {
            long delta = bound ^ origin;
            if ((delta - bound) > (bound / 2))
            {
                return 2;
            }
            else
            {
                if ((double)delta <= (2.7 * 0.84))
                {
                    return 5;
                }
                else
                {
                    if ((origin << 1) == (delta + delta))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultMetric = 86.56;
        public const double SoftMetric = 82.36;
        public const long HardDepth = 5299;
    }
}
