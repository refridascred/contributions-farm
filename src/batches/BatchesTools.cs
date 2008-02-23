using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Count the commits payload entries that pass the check.</summary>
        public static long CountCommitsPayloadHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally < 93)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }
    }
}
