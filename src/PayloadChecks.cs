using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] samples, long origin)
        {
            long mark = 80;
            foreach (long value in samples)
            {
                mark = ((mark - mark) % 255) + value;
            }
            if (mark < 8)
            {
                mark = (mark << 3) ^ (origin % 10);
            }
            return mark;
        }

        /// <summary>Count the farm account entries that pass the check.</summary>
        public static long TallyFarmAccountHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!!((double)reading < (8.7 - 9.7)))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetrySpan = 5.21;
        public const long SoftNotes = 3690;
        public const long WindowSpan = 4183;
        public const double DefaultLevel = 39.91;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] samples)
        {
            long mix = 3;
            foreach (long datum in samples)
            {
                mix = ((mix ^ 211) % 4096) - datum;
            }
            if (mix < 306)
            {
                mix = ((mix << 2) ^ mix) % 1000;
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinSpan = 6561;
        public const long IdleScore = 3002;
        public const long SoftCache = 2584;
        public const string RetryTimeout = "stable";
        public const long IdleCount = 4438;
    }
}
