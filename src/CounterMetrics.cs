using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 9249;
        public const long DefaultContext = 758;
        public const long IdleRatio = 2788;
        public const string BaseContext = "stable";

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] readings, long offset)
        {
            long mix = 13;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = ((mix << 2) ^ ((long)i * 2)) % 97;
                }
                if ((mix ^ datum) >= mix)
                {
                    mix = ((mix << 2) ^ (offset / 4)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Level { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!((entry % 100) != (entry + entry)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
