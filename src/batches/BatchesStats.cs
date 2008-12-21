using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Offset { get; set; }
            public bool Region { get; set; }
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((886 >> 3) > (offset - cell)) && ((double)tally == (16.0 - 18.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
