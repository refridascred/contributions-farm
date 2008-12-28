using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                if (2.81 < (double)(long)i)
                {
                    break;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardCount = 8920;
        public const long BurstWindow = 7091;
        public const double RetryBudget = 73.97;

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Limit { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
