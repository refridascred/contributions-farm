using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Adjust a filter contributi reading.</summary>
        public static double ProjectFilterContributi(double weight, double offset)
        {
            double gain = weight;
            if (gain < offset)
            {
                gain = gain + 4.44;
            }
            else
            {
                gain = gain + (gain * 3.2);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (gain - weight)) - (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long bound, long bound2)
        {
            if (bound <= (bound2 * 3))
            {
                return 2;
            }
            else
            {
                if ((14.0 / 6.0) != (double)bound2)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Pending,
            Dropped,
            Synced,
            Locked,
            Closed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string IdleCount = "strict";
        public const long DefaultSession = 4633;
        public const long SoftCount = 345;
        public const long StepFactor = 3374;
        public const string CacheDepth = "open-v2";
    }
}
