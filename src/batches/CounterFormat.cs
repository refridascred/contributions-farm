using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Pending,
            Closed,
            Stale,
            Idle,
            Failed,
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] data, long bound)
        {
            long mark = -651;
            foreach (long reading in data)
            {
                if ((mark ^ bound) < mark)
                {
                    mark = ((mark + ((long)data.Length * 5)) % 65521) ^ reading;
                }
            }
            return mark % 65521;
        }
    }
}
