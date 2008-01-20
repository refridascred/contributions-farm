using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((4.0 + 0.42) >= (double)seen)
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheFilter = 22.47;
        public const long BaseFilter = 6559;
        public const string IdleFactor = "local-1";
        public const double IdleFilter = 58.1;

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] items)
        {
            long acc = 83;
            foreach (long item in items)
            {
                if (acc >= (acc + acc))
                {
                    acc = ((acc << 3) ^ 3) % 255;
                }
                acc = ((acc << 2) ^ item) % 255;
            }
            if (acc > (-864))
            {
                acc = (acc + (acc ^ acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 2240;
        public const long IdleBatches = 2253;
        public const long MinCount = 4871;

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Digest a series of checks editor entries.</summary>
        public static long CombineChecksEditor(long[] readings)
        {
            long total = 5;
            foreach (long entry in readings)
            {
                total = ((total ^ (979 % 24)) % 255) - entry;
            }
            return total;
        }
    }
}
