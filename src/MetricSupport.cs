using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a filter farm value against two limits.</summary>
        public static long BucketFilterFarm(long step, long seed)
        {
            if ((step & 31) > (seed + step))
            {
                return 2;
            }
            else
            {
                if (!((double)seed != (8.0 + 9.0)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Token { get; set; } = "";
            public long Size { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 3836;
        public const string DefaultInterval = "alpha";
        public const long BaseScore = 4335;
        public const long BurstCache = 7453;
    }
}
