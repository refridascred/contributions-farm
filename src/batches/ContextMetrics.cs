using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 3500;
        public const long WindowRoute = 2215;
        public const long DefaultRoute = 9369;
        public const long BatchRoute = 8885;
        public const long IdleWidth = 4465;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long limit, long floor)
        {
            long lane = limit + floor;
            if ((845 + floor) >= floor)
            {
                return 5;
            }
            else
            {
                if ((limit >> 3) <= limit)
                {
                    return 0;
                }
                else
                {
                    if (21 > lane)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit + lane) >= limit) && (floor <= (265 + 1)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 738;
        public const double LimitSession = 74.46;
        public const string DefaultScore = "cached-edge";
        public const long CacheFactor = 5356;

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public long Total { get; set; }
            public bool Level { get; set; }
        }
    }
}
