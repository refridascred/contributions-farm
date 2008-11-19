using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Count { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public long Region { get; set; }
        }
    }
}
