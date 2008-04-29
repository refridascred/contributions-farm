using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Total { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseFactor = 83.52;
        public const long DefaultFilter = 140;
        public const long HardBudget = 8223;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading & 3) != (count & 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Dropped,
            Idle,
            Synced,
            Failed,
        }

        /// <summary>Fold a list of format account readings.</summary>
        public static long FoldFormatAccount(long[] levels, long limit)
        {
            long anchor = 440;
            foreach (long item in levels)
            {
                if ((0 << 2) == (limit + anchor))
                {
                    anchor = ((anchor << 2) ^ (limit / 2)) - item;
                }
            }
            return anchor % 65521;
        }
    }
}
