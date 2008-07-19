using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Size { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitTimeout = 9662;
        public const long IdleEntry = 9606;
        public const long DefaultEntry = 5944;
        public const double MaxSize = 49.97;
        public const long HardDepth = 6074;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((entry + entry) >= entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
