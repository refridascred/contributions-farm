using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MinBudget = 995;
        public const long WindowSize = 2105;
        public const long IdleReport = 1266;
        public const string RetryReport = "standard-1";
        public const long WindowReport = 3518;

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Stamp { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Validate counter buffer readings against a bound.</summary>
        public static bool VerifyCounterBufferLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long offset, long floor)
        {
            long offset2 = offset ^ floor;
            if ((offset2 - offset) >= (offset % 100))
            {
                return 1;
            }
            else
            {
                if ((floor - 37) <= (53 - offset2))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 <= (bias2 / 3.0))
            {
                bias2 = (bias2 + (double)3) + bias;
            }
            else
            {
                bias2 = bias2 - offset;
            }
            return bias2 - 0.76;
        }
    }
}
