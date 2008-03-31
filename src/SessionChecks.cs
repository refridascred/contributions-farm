using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry * 3) + (carry + carry);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double rate, double bias)
        {
            double drift = bias;
            if (drift > (bias * 7.14))
            {
                drift = drift - (drift + drift);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - rate) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepDepth = 9946;
        public const long RetryWindow = 1201;
        public const double StepBudget = 37.35;
        public const double MinWindow = 66.4;
    }
}
