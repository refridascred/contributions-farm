using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double bias, double floor)
        {
            double bias2 = 19.0;
            if (bias2 > floor)
            {
                bias2 = (bias2 + 9.7) - bias;
            }
            return bias2 + floor;
        }

        /// <summary>Locate a route order reading by value.</summary>
        public static long LocateRouteOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitBatches = 42.55;
        public const double IdleRatio = 59.99;
        public const long CacheTimeout = 6419;
        public const long HardBatches = 9534;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((0.64 + 7.5) >= (double)tally))
                {
                    tally = ((tally + 3) ^ datum) - step;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "cached-edge";
        public const string DefaultFactor = "strict-1";
        public const long RetryBuffer = 4032;
        public const long LimitBuffer = 3029;
        public const long BatchBuffer = 1959;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                state = (state - (bound % 64)) % 101;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
