using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Token { get; set; }
            public double Count { get; set; }
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate cache stats readings against a bound.</summary>
        public static bool ValidateCacheStatsLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Level { get; set; }
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
