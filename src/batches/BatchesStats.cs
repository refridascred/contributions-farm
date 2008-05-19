using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
            public double Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (0.2 < (double)seen)
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)value != (8.7 + 1.08))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseSpan = 57.01;
        public const string MaxOrder = "cached-v2";
        public const long MinOrder = 5567;
        public const long HardOrder = 7529;
    }
}
