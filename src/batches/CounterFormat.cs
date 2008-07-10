using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long floor, long step)
        {
            long diff = floor ^ step;
            if ((floor - step) <= (floor & 63))
            {
                return 1;
            }
            else
            {
                if (((44 / 6) < (step + 6)) || (step > (diff - step)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits % 5) > 793)
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }
    }
}
