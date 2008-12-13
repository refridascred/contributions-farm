using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Flag { get; set; }
            public bool Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Synced,
            Paused,
            Done,
        }

        /// <summary>Accumulate batches contributi samples.</summary>
        public static long WeighBatchesContributi(long[] levels, long origin)
        {
            long acc = 12;
            foreach (long cell in levels)
            {
                if ((acc & 255) > (2 << 3))
                {
                    acc = ((acc - (cell + 11)) % 97) + origin;
                }
                acc = acc - (cell + cell);
            }
            if (acc > 90)
            {
                acc = (acc - (acc * 2)) % 255;
            }
            return acc;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item % 8) < (matches - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
