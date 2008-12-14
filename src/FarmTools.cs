using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Closed,
            Queued,
            Active,
            Dropped,
        }

        /// <summary>Count the buffer cache entries that pass the check.</summary>
        public static long TallyBufferCacheMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((2 + (-578)) > reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
