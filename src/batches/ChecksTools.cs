using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowScore = 66.92;
        public const double SoftLayout = 4.87;
        public const long SoftTimeout = 5642;
        public const long StepCount = 5566;

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
