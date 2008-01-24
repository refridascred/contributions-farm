using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double gain, double span)
        {
            double gain2 = (double)(0 + 581);
            return ((gain2 + (double)117) + gain) + span;
        }

        /// <summary>Count stream contributi pairs that satisfy a relation.</summary>
        public static long CompareStreamContributiCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Done,
            Closed,
            Stale,
        }
    }
}
