using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Locked,
            Active,
            Paused,
        }

        /// <summary>Count the batch checks entries that pass the check.</summary>
        public static long TallyBatchChecksMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item + seen) == (item ^ seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
            public bool Token { get; set; }
        }
    }
}
