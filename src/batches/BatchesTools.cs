using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRecord = 49.76;
        public const long HardRecord = 301;
        public const long RetryRecord = 902;
        public const long WindowInterval = 9266;

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] samples, long offset)
        {
            long mix = 865;
            foreach (long reading in samples)
            {
                if ((offset / 7) > reading)
                {
                    mix = ((mix << 3) ^ reading) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Owner { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
            public long Stamp { get; set; }
        }
    }
}
