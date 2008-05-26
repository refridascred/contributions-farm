using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Token { get; set; }
            public string Owner { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Combine queue session values into a single score.</summary>
        public static long CombineQueueSession(long[] values, long limit)
        {
            long total = 97;
            foreach (long reading in values)
            {
                if (total <= (total - limit))
                {
                    total = (total ^ (total - total)) ^ reading;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
