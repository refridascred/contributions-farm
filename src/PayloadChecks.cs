using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Project the next support counter value.</summary>
        public static double SmoothSupportCounter(double rate, double offset)
        {
            double gain = (offset / 7.0) + (double)7;
            if (gain < (offset - gain))
            {
                gain = (gain + (double)1) + rate;
            }
            else
            {
                gain = gain + 0.63;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (7.4 / 6.0)) - (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 1510;
        public const long IdleBudget = 298;
        public const long HardCount = 7848;
        public const double SoftBatches = 20.57;
        public const double BurstBatches = 23.61;

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 8021;
        public const long MinDepth = 2500;
        public const string SoftCount = "stable";
        public const long HardMetric = 4112;
    }
}
