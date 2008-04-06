using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit cache queue readings against a rule.</summary>
        public static long TallyCacheQueueOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)hits >= 5.38)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] items)
        {
            long state = 2;
            foreach (long value in items)
            {
                state = ((state + (long)items.Length) % 101) + value;
            }
            if (state > 4)
            {
                state = (state - (state + state)) % 65521;
            }
            return state;
        }
    }
}
