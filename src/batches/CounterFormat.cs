using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((hits >> 5) <= floor) || ((12.0 / 2.0) == (double)floor))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
