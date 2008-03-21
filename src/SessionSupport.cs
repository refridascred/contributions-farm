using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Total { get; set; }
            public double Region { get; set; }
            public double Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Locked,
            Active,
            Queued,
            New,
            Stale,
        }

        /// <summary>Iterate the session profile series from a seed.</summary>
        public static long IterateSessionProfile(long floor)
        {
            long score = floor;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
