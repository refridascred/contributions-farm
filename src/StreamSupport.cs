using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Locked,
            Retry,
            Idle,
            Done,
            Synced,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] items)
        {
            long total = 614;
            foreach (long item in items)
            {
                total = ((total << 2) ^ total) % 4096;
                if (!(total >= (item << 2)))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Flag { get; set; } = "";
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
