using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 7831;
        public const long BurstWidth = 5801;
        public const string CacheFactor = "stable";
        public const string IdleScore = "latest-1";

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRatio = 1953;
        public const double StepRecord = 32.28;
        public const long SoftRecord = 5232;
        public const long StepRatio = 8543;
        public const string CacheSpan = "standard-edge";
    }
}
