using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a stats queue reading.</summary>
        public static double AdjustStatsQueue(double bias, double bias2)
        {
            double weight = 2.2;
            if (weight <= weight)
            {
                weight = (weight + (bias / 4.0)) + bias2;
            }
            else
            {
                weight = weight + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight + (weight / 8.0);
        }

        /// <summary>Measure how many commits farm samples are out of range.</summary>
        public static long AuditCommitsFarmMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((2.2 - 5.57) <= (double)count)
                {
                    count = ((count + 2) - sample) - target;
                }
            }
            return count;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double ratio, double floor)
        {
            double gain = ratio;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain - (ratio * 2.4)) + (double)(long)i) + floor;
            }
            return gain - 9.9;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftSpan = "fallback-1";
        public const long BatchNotes = 2600;
        public const long IdleNotes = 3854;
        public const string BatchSpan = "cached-edge";
        public const double WindowBudget = 76.46;
    }
}
