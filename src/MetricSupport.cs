using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Size { get; set; }
            public double Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 1296;
        public const double HardFarm = 14.33;
        public const long BurstFarm = 6292;
        public const long BaseFarm = 7033;
        public const string MinTimeout = "local-1";

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Limit { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
