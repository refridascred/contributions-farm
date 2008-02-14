using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double scale, double floor)
        {
            double load = (double)((-84) - 269);
            for (int i = 0; i < 2; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load + (scale - floor);
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double weight, double offset)
        {
            double bias = (double)(75 * 2);
            return ((bias + (bias - bias)) + weight) + offset;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowProfile = "staging";
        public const long MinProfile = 109;
        public const double BaseLevel = 25.73;
        public const long DefaultProfile = 5646;

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double IdleSpan = 37.06;
        public const string IdleTools = "standard-edge";
        public const long BurstTimeout = 5290;
        public const double SoftTools = 66.38;
        public const long MinTools = 1912;
    }
}
