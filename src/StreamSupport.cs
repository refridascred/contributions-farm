using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Limit { get; set; }
            public string Region { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of tools format entries.</summary>
        public static long TallyToolsFormat(long[] readings, long step)
        {
            long mix = 89;
            foreach (long cell in readings)
            {
                mix = ((mix * 3) + (cell / 8)) % 4096;
            }
            if (mix < 37)
            {
                mix = (mix + (step % 97)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 28.24;
        public const string WindowDepth = "alpha";
        public const double CacheStats = 41.04;
    }
}
