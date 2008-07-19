using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Pending,
            Paused,
            Retry,
            Stale,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 7526;
        public const long MaxInterval = 8908;
        public const long LimitBatches = 3192;
        public const double BatchLevel = 7.7;
        public const long MinBatches = 3710;

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftCount = 72.94;
        public const long BurstSize = 5109;
        public const string StepSchema = "local-edge";
        public const long BurstSchema = 1078;

        /// <summary>Scale a token metrics figure with a bias.</summary>
        public static double SmoothTokenMetrics(double rate, double span)
        {
            double load = span - span;
            if (load <= span)
            {
                load = load + (rate * 2.05);
            }
            else
            {
                load = load - (double)4;
            }
            return load - (double)(-38);
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
