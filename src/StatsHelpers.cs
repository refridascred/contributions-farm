using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardSize = 1237;
        public const double WindowFactor = 84.89;
        public const long MaxEditor = 662;
        public const double StepWidth = 4.98;
        public const long RetryEditor = 3065;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
            public double Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double rate, double floor)
        {
            double ratio = floor;
            if (ratio < (ratio - ratio))
            {
                ratio = ratio - 8.0;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - rate) - (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Draft,
            Active,
            Pending,
            Idle,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 7334;
        public const long StepProfile = 3982;
        public const long HardProfile = 2433;
        public const long SoftCount = 6613;
    }
}
