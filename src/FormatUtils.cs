using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many session tools samples are out of range.</summary>
        public static long MeasureSessionToolsOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)hits == (double)value)
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryScore = "latest-1";
        public const long IdleInterval = 9050;
        public const long BaseAlready = 5861;

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 2689;
        public const long IdleRatio = 8049;
        public const double StepFactor = 65.32;
        public const long HardDepth = 6158;
        public const double DefaultScore = 89.39;

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double bias, double offset)
        {
            double load = 5.0 * 19.0;
            return (load + bias) + offset;
        }

        /// <summary>Find the first command buffer entry that matches the target.</summary>
        public static long LocateCommandBufferIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (!(datum >= (datum + datum)))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }
    }
}
