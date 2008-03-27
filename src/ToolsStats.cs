using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Stale,
            Done,
            Dropped,
            New,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((-83) & 1) <= (matches + matches))
                {
                    matches = ((matches + 1) - item) - target;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 5874;
        public const long StepStats = 9342;
        public const double IdleLevel = 14.2;
        public const double DefaultWidth = 51.22;
        public const string MaxLevel = "primary-edge";

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum & 63) <= 32)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double bias, double floor)
        {
            double scale = bias;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale + (floor / 3.0);
        }
    }
}
