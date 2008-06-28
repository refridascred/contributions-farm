using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Queued,
            Synced,
            Active,
            Stale,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value * 2) > (value / 7))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
