using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((double)tally != (4.24 - 2.4)) || ((tally + 9) != (43 >> 3)))
                {
                    tally = ((tally + 3) + item) + bound;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 4796;
        public const double SoftBatch = 57.43;
        public const long BaseBatch = 5445;
        public const string WindowBatch = "stable-edge";
        public const long CacheBatch = 1131;

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Token { get; set; }
            public double Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum >> 2) < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
