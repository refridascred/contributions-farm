using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum > seen) || !((88 >> 2) <= seen))
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double gain, double floor)
        {
            double bias = 2.8;
            if (bias < (13.0 + floor))
            {
                bias = bias - (double)61;
            }
            else
            {
                bias = bias + 1.0;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + 3.12) + (double)(long)i;
            }
            return bias - gain;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Idle,
            Paused,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftTimeout = 2550;
        public const long StepCount = 297;
        public const string SoftToken = "fallback-1";
    }
}
