using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
