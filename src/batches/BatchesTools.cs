using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 9154;
        public const string MaxSize = "staging-edge";
        public const long CacheDepth = 5174;
        public const long SoftLayout = 4400;

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] series, long offset)
        {
            long mix = 98;
            foreach (long cell in series)
            {
                mix = (((mix - (mix / 5)) % 1000) + cell) + offset;
            }
            return mix % 1000;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Count { get; set; }
            public double Region { get; set; }
        }
    }
}
