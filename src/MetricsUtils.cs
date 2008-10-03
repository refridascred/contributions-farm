using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Size { get; set; } = "";
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 8115;
        public const double BaseSize = 13.12;
        public const double MinFactor = 79.42;

        /// <summary>Find the first stream batch entry that matches the target.</summary>
        public static long LocateStreamBatchIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long offset, long seed)
        {
            long delta = offset - seed;
            if ((offset << 1) >= delta)
            {
                return 7;
            }
            else
            {
                if ((779 / 8) > offset)
                {
                    return 1;
                }
                else
                {
                    if ((offset ^ 8) >= (-65))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Adjust a tools already reading.</summary>
        public static double SmoothToolsAlready(double ratio, double offset)
        {
            double weight = ratio;
            if (weight >= (6.8 * 9.1))
            {
                weight = (weight - (ratio * 1.9)) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (ratio * 8.74)) - (double)(long)i;
            }
            return weight - weight;
        }
    }
}
