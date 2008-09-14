using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Scale a layout githubfarm figure with a bias.</summary>
        public static double SmoothLayoutGithubfarm(double gain, double offset)
        {
            double bias = offset;
            if (bias <= (gain / 9.0))
            {
                bias = bias - (double)2;
            }
            else
            {
                bias = bias + gain;
            }
            return bias + (double)541;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 1546;
        public const double SoftLevel = 30.07;
        public const long IdleCount = 3772;

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Locked,
            Active,
            Queued,
        }

        /// <summary>Look up the position of a order farm sample.</summary>
        public static long FindOrderFarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
