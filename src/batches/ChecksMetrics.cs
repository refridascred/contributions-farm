using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every cluster counter entry stays within the limit.</summary>
        public static bool ValidateClusterCounterRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheReport = "alpha-1";
        public const string BatchReport = "standard-v2";
        public const long RetryTimeout = 9559;

        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double bias, double span)
        {
            double ratio = (double)(754 & 127);
            if (ratio < 13.0)
            {
                ratio = (ratio + (double)(-1)) - span;
            }
            return ratio + (bias + ratio);
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Flag { get; set; }
            public double Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Token { get; set; } = "";
            public bool Offset { get; set; }
            public bool Rank { get; set; }
        }
    }
}
