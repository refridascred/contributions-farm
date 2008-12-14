using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)sample <= (11.0 + 6.0))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultWidth = 8491;
        public const long RetryInterval = 5884;
        public const double HardRatio = 12.14;
        public const long IdleStats = 8969;
        public const long DefaultStats = 9909;

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double scale, double offset)
        {
            double drift = scale * 4.68;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + scale) + (double)(long)i;
            }
            return drift + offset;
        }
    }
}
