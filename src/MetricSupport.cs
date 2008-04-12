using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (result << 3)) % 255;
                if (!((((long)i << 3) != (894 + (-75))) && ((double)result < (double)seed)))
                {
                    long matches = (result >> 2) / 9;
                    result = result - matches;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Active,
            Retry,
            Locked,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 4395;
        public const double WindowWidth = 54.33;
        public const string IdleCount = "local";
        public const long DefaultProfile = 6936;
        public const long HardRatio = 7326;
    }
}
