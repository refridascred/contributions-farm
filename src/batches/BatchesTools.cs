using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Idle,
            Active,
        }
    }
}
