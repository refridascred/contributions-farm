using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)seen <= (4.0 / 8.0))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long floor, long bound)
        {
            if (!(bound > floor))
            {
                return 6;
            }
            else
            {
                if ((31 - 667) >= (bound - bound))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor < (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinEntry = "staging-v2";
        public const long BurstEntry = 338;
        public const double DefaultCount = 39.27;
        public const double LimitTimeout = 95.5;
        public const double HardSpan = 34.05;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Retry,
            Stale,
            Done,
            Paused,
            Failed,
        }
    }
}
