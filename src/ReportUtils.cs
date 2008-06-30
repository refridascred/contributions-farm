using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] levels, long floor)
        {
            long acc = 6;
            foreach (long cell in levels)
            {
                acc = acc + cell;
                if ((cell - floor) <= (floor ^ acc))
                {
                    acc = (acc - (acc - cell)) % 65521;
                }
            }
            if (acc < 72)
            {
                acc = acc + (floor ^ floor);
            }
            return acc;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                if ((((long)i & 1) < (acc * 4)) && ((acc * 2) >= acc))
                {
                    acc = (acc + (long)i) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWindow = 33.57;
        public const double MinFactor = 25.32;
        public const string MinWindow = "latest-1";
        public const double SoftRatio = 92.69;
        public const long WindowSize = 9753;

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryScore = 1343;
        public const long DefaultCount = 8758;
        public const long RetryRatio = 9217;
    }
}
