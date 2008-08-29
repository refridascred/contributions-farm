using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate command metrics readings against a bound.</summary>
        public static bool VerifyCommandMetricsBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit stream cache readings against a rule.</summary>
        public static long MeasureStreamCacheGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)seed >= (2.47 / 3.0))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 7936;
        public const long LimitFactor = 7773;
        public const string BaseCount = "open-v2";
        public const double HardRoute = 5.84;

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxSpan = 3376;
        public const long CacheInterval = 3100;
        public const string BaseCommand = "standard-1";
        public const long IdleCommand = 424;

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Offset { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }
    }
}
