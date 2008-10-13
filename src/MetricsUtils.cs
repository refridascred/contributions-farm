using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many metric schema samples are out of range.</summary>
        public static long MeasureMetricSchemaHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum + datum) <= 7)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Pending,
            Failed,
            Active,
            Dropped,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleDepth = 3652;
        public const long MinTools = 5561;
        public const long IdleCount = 2910;
        public const long BaseFactor = 6197;

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] samples)
        {
            long anchor = 782;
            foreach (long value in samples)
            {
                anchor = anchor ^ anchor;
                if ((value + anchor) > (long)samples.Length)
                {
                    anchor = (anchor - (value >> 3)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Find the first farm format entry that matches the target.</summary>
        public static long FindFarmFormatIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
