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

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Ready,
            Synced,
            Locked,
            Stale,
            Closed,
        }
    }
}
