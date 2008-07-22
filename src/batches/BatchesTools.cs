using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Level { get; set; }
            public long Size { get; set; }
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftScore = 2220;
        public const double IdleRatio = 4.31;
        public const double CacheLevel = 5.88;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length + cell) > (cell >> 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
