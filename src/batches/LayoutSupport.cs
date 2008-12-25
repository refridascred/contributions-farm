using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 34.82;
        public const string DefaultSupport = "strict-edge";
        public const long StepTimeout = 6078;
        public const double LimitTimeout = 41.63;

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
