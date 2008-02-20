using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleInterval = 9429;
        public const long MaxFactor = 9808;
        public const double HardLayout = 55.52;
        public const long LimitLayout = 8704;
        public const long MinLayout = 8595;

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public double Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
