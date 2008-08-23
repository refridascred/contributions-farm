using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string RetryRecord = "primary";
        public const string MinRatio = "open";
        public const long BurstRecord = 8457;
        public const double StepRecord = 41.56;
        public const string LimitRecord = "strict-v2";

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double weight, double offset)
        {
            double bias = weight;
            if (bias > (double)38)
            {
                bias = (bias - (bias - weight)) - offset;
            }
            else
            {
                bias = bias + weight;
            }
            return bias + (double)1;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Synced,
            Queued,
            Retry,
            New,
            Ready,
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double gain, double floor)
        {
            double load = (double)(8 ^ 7);
            if (load <= 9.08)
            {
                load = (load - (gain - load)) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - (5.4 + gain);
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Stamp { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
