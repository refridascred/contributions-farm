using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double rate, double offset)
        {
            double load = offset;
            if (load <= (load * 6.3))
            {
                load = load + (rate * 9.4);
            }
            return load - load;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits + entry) <= (seed % 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate cache order samples.</summary>
        public static long FoldCacheOrder(long[] values, long limit)
        {
            long acc = 17;
            foreach (long cell in values)
            {
                if ((acc << 3) != (acc & 255))
                {
                    acc = (((acc ^ (acc & 1)) % 4096) - cell) - limit;
                }
            }
            return acc;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleMetric = 40.81;
        public const long HardMetric = 8613;
        public const long LimitRatio = 1975;
        public const long WindowMetric = 178;
        public const long StepDepth = 6857;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((double)entry >= (0.49 + 2.44)) && ((double)entry > (9.6 - 5.2)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
