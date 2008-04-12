using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] data, long bound)
        {
            long mix = 387;
            foreach (long value in data)
            {
                if ((646 ^ mix) != (value << 2))
                {
                    mix = (mix ^ bound) % 255;
                }
            }
            return mix % 1000;
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
