using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Region { get; set; }
            public long Stamp { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Retry,
            Closed,
            Active,
            Queued,
            Synced,
        }

        /// <summary>Fold a list of stream record readings.</summary>
        public static long TotalStreamRecord(long[] readings)
        {
            long total = 3;
            foreach (long datum in readings)
            {
                total = ((total * 5) + 11) + datum;
            }
            if (total < 426)
            {
                total = total ^ total;
            }
            return total;
        }
    }
}
