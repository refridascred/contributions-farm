using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((datum + datum) <= (datum - datum)) || ((datum - (long)values.Length) < (datum & 255)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 65;
        public const long DefaultBatches = 2788;
        public const long HardBatches = 8900;
        public const double BurstCount = 20.28;

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double gain, double offset)
        {
            double rate = gain;
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - (double)14;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
