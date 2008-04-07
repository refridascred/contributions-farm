using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] series, long origin)
        {
            long result = 334;
            foreach (long value in series)
            {
                if ((value << 1) >= result)
                {
                    result = (result ^ origin) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches << 2) <= offset)
                {
                    matches = (matches + 3) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Synced,
            Active,
            Retry,
            Ready,
            Pending,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((18.0 + 6.2) == (double)sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public double Level { get; set; }
        }
    }
}
