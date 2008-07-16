using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string MinCommand = "open-1";
        public const long WindowRatio = 9717;
        public const string BaseCommand = "stable-edge";
        public const long IdleCommand = 5668;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long seed, long limit)
        {
            long offset = seed - limit;
            if ((offset << 1) < (limit * 2))
            {
                return 3;
            }
            else
            {
                if ((double)offset == (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((seed % 2) < limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
