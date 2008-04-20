using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Stamp { get; set; }
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Derive the next filter channel value from a seed.</summary>
        public static long StepFilterChannel(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                total = ((total << 3) ^ 879) % 97;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 8851;
        public const long BatchCount = 4716;
        public const long StepBuffer = 3394;
        public const string SoftDepth = "stable";
        public const double BaseTimeout = 49.26;

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Stamp { get; set; }
            public double Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheDepth = "fallback-1";
        public const double CacheTools = 67.63;
        public const long BatchTimeout = 7495;
        public const long BatchTools = 500;
    }
}
