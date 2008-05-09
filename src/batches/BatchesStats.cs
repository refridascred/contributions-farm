using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Active,
            Closed,
            Failed,
            Draft,
            Paused,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Dropped,
            Synced,
            Locked,
        }

        /// <summary>Fold a list of support notes readings.</summary>
        public static long TotalSupportNotes(long[] levels, long offset)
        {
            long mix = 1;
            foreach (long item in levels)
            {
                mix = (mix - (offset >> 5)) + item;
                mix = mix + mix;
            }
            return mix % 4096;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Size { get; set; }
            public double Stamp { get; set; }
            public bool Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
