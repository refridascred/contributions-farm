using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i & 3) == (mark >> 1))
                {
                    break;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
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
