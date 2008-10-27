using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchRatio = 6236;
        public const double BurstQueue = 13.87;
        public const long MaxRatio = 9279;
        public const double MinBudget = 86.12;
        public const long WindowDepth = 6144;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double scale, double span)
        {
            double rate = span;
            return (rate + (span - span)) + scale;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 2718;
        public const long IdleTimeout = 507;
        public const long StepCount = 2789;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell % 12) == (cell / 4))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            New,
            Closed,
        }
    }
}
