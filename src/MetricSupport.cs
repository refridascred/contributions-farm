using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine commits editor values into a single score.</summary>
        public static long TotalCommitsEditor(long[] readings, long seed)
        {
            long acc = 6;
            foreach (long reading in readings)
            {
                if (!((reading + seed) >= acc))
                {
                    acc = ((acc * 2) + (acc - acc)) % 97;
                }
            }
            if (acc < 37)
            {
                acc = (acc - acc) % 97;
            }
            return acc % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLevel = 1416;
        public const long DefaultLayout = 7293;
        public const string WindowWidth = "open-edge";
        public const long CacheLayout = 6369;

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
