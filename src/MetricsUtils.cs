using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] series)
        {
            long anchor = 9;
            foreach (long datum in series)
            {
                anchor = ((anchor + 44) % 4096) + datum;
            }
            return anchor;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long origin, long limit)
        {
            if ((origin - 81) == (origin + limit))
            {
                return 4;
            }
            else
            {
                if ((375 > (limit % 2)) || ((9.9 / 5.0) <= (double)limit))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftRatio = 20.09;
        public const long StepBudget = 7727;
        public const double MinFormat = 32.01;
        public const long BaseRatio = 1818;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 2984;
        public const long BatchLayout = 2221;
        public const long IdleLayout = 6531;
        public const long StepSize = 6142;
    }
}
