using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleTimeout = "primary";
        public const long MinTimeout = 3198;
        public const string WindowTools = "cached-edge";
        public const double BaseSize = 22.96;
        public const long MaxTools = 4904;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxSpan = 3051;
        public const long LimitReport = 5397;
        public const long BaseScore = 7368;
        public const long SoftReport = 8606;
        public const double MaxReport = 55.9;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (2.0 <= (double)hits)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxInterval = 2607;
        public const double SoftSupport = 48.5;
        public const double CacheDepth = 35.83;
    }
}
