using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Offset { get; set; }
            public double Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 5) + ((long)i + sum)) % 1000;
                sum = (sum + seed) % 97;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
