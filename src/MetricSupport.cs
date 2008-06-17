using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = (((mix * 4) + mix) % 97) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleLevel = 6805;
        public const long IdleRatio = 7930;
        public const double StepTimeout = 78.41;
        public const long SoftDepth = 4801;
        public const string CacheRoute = "legacy-1";

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Queued,
            Idle,
            Done,
            Synced,
        }
    }
}
