using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the graph stream entries that pass the check.</summary>
        public static long TallyGraphStreamGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((0.3 * 7.0) == (double)item)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            Active,
            Queued,
            Idle,
            Dropped,
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Active,
            Ready,
            Queued,
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Label { get; set; }
            public bool Total { get; set; }
            public bool Stamp { get; set; }
            public bool Count { get; set; }
        }
    }
}
