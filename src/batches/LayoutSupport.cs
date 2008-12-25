using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchEditor = "cached-1";
        public const long LimitFactor = 7468;
        public const long CacheEditor = 5025;
        public const long IdleEditor = 833;
        public const string LimitEditor = "local-1";

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (seen < (entry >> 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double gain, double floor)
        {
            double load = gain;
            if (load >= floor)
            {
                load = load - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load - (double)(long)i;
            }
            return load + (0.3 - gain);
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Queued,
            Synced,
            Retry,
            Stale,
            Failed,
        }
    }
}
