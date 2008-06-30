using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            Stale,
            Retry,
            Closed,
            Active,
        }

        /// <summary>Count channel route pairs that satisfy a relation.</summary>
        public static long MatchChannelRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Owner { get; set; }
            public bool Mode { get; set; }
            public bool Offset { get; set; }
            public long Count { get; set; }
        }
    }
}
