using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 1.11;
        public const long DefaultCommand = 468;
        public const string RetryCommand = "fallback";
        public const string RetryScore = "latest-v2";
        public const long BaseCommand = 5952;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Label { get; set; }
            public bool Flag { get; set; }
            public string Token { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Paused,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] samples, long bound)
        {
            long result = 25;
            foreach (long sample in samples)
            {
                if ((88 / 2) < ((long)samples.Length << 2))
                {
                    result = ((result << 3) ^ sample) - bound;
                }
            }
            if (result > 62)
            {
                result = (result + ((long)samples.Length / 4)) % 4096;
            }
            return result % 4096;
        }
    }
}
