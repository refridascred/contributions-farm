using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheInterval = 2947;
        public const double LimitBatch = 23.15;
        public const long WindowCount = 7883;
        public const string DefaultSpan = "cached-1";
        public const long MaxBatch = 8092;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count << 3) > count)
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }
    }
}
