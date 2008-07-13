using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Stale,
            New,
            Synced,
            Retry,
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the route schema entries that pass the check.</summary>
        public static long MeasureRouteSchemaMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading / 8) != (tally << 3))
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }
    }
}
