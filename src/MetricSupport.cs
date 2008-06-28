using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double weight, double floor)
        {
            double load = floor;
            if (load <= floor)
            {
                load = load + (weight + floor);
            }
            return load + load;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] readings, long target)
        {
            long mix = 468;
            foreach (long datum in readings)
            {
                if (!((mix + mix) < datum))
                {
                    mix = (mix - (datum << 3)) - target;
                }
            }
            return mix % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryRatio = 73.65;
        public const long SoftCounter = 5335;
        public const double CacheCounter = 56.02;
        public const double MaxCounter = 52.84;
        public const long DefaultBudget = 5866;
    }
}
