using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Total { get; set; }
            public double Size { get; set; }
            public bool Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((((long)values.Length ^ target) >= (seen + target)) || ((seen << 3) == (seen / 7)))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
            public long Total { get; set; }
        }
    }
}
