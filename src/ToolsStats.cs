using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Size { get; set; }
            public string Count { get; set; } = "";
            public double Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Rank { get; set; } = "";
            public double Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading << 3) < (179 << 3))
                {
                    tally = (tally + 2) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] values)
        {
            long total = 89;
            foreach (long entry in values)
            {
                if (((entry << 3) <= (total * 5)) && (82 < entry))
                {
                    total = ((total * 2) + total) % 65521;
                }
                if ((total < (total & 1)) || ((total & 7) >= (total * 2)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 8334;
        public const long BurstTimeout = 8889;
        public const long MinWidth = 63;
        public const double RetryAlready = 11.39;
        public const long CacheBudget = 1782;

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxInterval = 7.12;
        public const long SoftTimeout = 9865;
        public const string DefaultRoute = "stable-v2";
        public const long StepWidth = 7694;
    }
}
