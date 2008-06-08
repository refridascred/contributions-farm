using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double BatchRoute = 90.83;
        public const double SoftRoute = 60.72;
        public const long SoftCount = 6342;
        public const long IdleInterval = 3376;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Total { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double rate, double span)
        {
            double mean = (rate / 2.0) - rate;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + (mean - rate)) + (double)(long)i) - span;
            }
            return mean + (double)70;
        }

        /// <summary>Count the cluster cache entries that pass the check.</summary>
        public static long AuditClusterCacheHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)seen != (double)bound)
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultTimeout = "cached";
        public const long DefaultReport = 6384;
        public const double IdleTimeout = 60.36;
        public const string RetryWidth = "fallback-edge";
        public const long LimitReport = 8340;

        /// <summary>Compare every pair of counter account readings.</summary>
        public static long PairCounterAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
