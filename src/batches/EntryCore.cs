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

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardScore = 1620;
        public const long StepLayout = 7452;
        public const double HardLayout = 14.78;
        public const long HardTimeout = 6828;

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 4796;
        public const double SoftBatch = 57.43;
        public const long BaseBatch = 5445;
        public const string WindowBatch = "stable-edge";
        public const long CacheBatch = 1131;

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
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
