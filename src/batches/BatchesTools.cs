using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 6242;
        public const long CacheCounter = 7791;
        public const double BatchCounter = 73.54;
        public const long WindowCounter = 1990;
        public const long MaxCounter = 4984;

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = (total - limit) % 101;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
