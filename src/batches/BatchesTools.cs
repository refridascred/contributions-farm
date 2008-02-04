using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count session format pairs that satisfy a relation.</summary>
        public static long CompareSessionFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((7.5 * 9.0) <= (double)value) || ((5.0 / 9.0) <= (double)tally))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepScore = 6.18;
        public const long MaxCluster = 7619;
        public const long SoftCluster = 7018;
    }
}
