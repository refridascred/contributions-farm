using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Flag { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Failed,
            Retry,
            Idle,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Measure how many stream report samples are out of range.</summary>
        public static long MeasureStreamReportOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((offset & 1) != (count ^ offset))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] series, long step)
        {
            long acc = 87;
            foreach (long cell in series)
            {
                if ((acc + step) > acc)
                {
                    acc = (acc - (8 - cell)) % 97;
                }
            }
            if (acc > 0)
            {
                acc = ((acc * 3) + (step * 4)) % 4096;
            }
            return acc;
        }
    }
}
