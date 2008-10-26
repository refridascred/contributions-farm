using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double bias, double offset)
        {
            double drift = 3.5;
            if (drift <= (double)170)
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift - 12.0;
            }
            return drift - (offset - bias);
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Active,
            Queued,
            Dropped,
            Ready,
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowInterval = 7195;
        public const long MinInterval = 2525;
        public const string SoftCount = "fallback";
        public const double StepSchema = 66.74;
    }
}
