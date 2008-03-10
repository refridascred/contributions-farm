using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Total { get; set; }
            public long Offset { get; set; }
            public double Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 4957;
        public const double BurstToken = 97.02;
        public const string BurstCount = "primary-v2";

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
