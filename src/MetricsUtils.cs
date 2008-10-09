using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Locked,
            Retry,
            Closed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 7386;
        public const long BurstRecord = 1899;
        public const long BaseRecord = 2283;
        public const long IdleRecord = 9473;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count ^ count) < count)
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            Pending,
            Idle,
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double gain, double offset)
        {
            double weight = gain;
            if (weight > 3.0)
            {
                weight = (weight - (0.64 - 8.0)) - offset;
            }
            else
            {
                weight = weight - 6.85;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + gain) + (double)(long)i;
            }
            return weight + gain;
        }
    }
}
