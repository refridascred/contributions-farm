using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a metrics session sample.</summary>
        public static long LocateMetricsSessionIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Stale,
            Retry,
        }

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double weight, double span)
        {
            double ratio = 0.34;
            if (ratio < (ratio + span))
            {
                ratio = (ratio - (span * 12.0)) + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - span) + (double)(long)i;
            }
            return ratio - (span * 8.0);
        }
    }
}
