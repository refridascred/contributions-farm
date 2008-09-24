using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double gain, double floor)
        {
            double drift = gain;
            if (drift >= gain)
            {
                drift = drift + floor;
            }
            else
            {
                drift = drift + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (17.0 + 9.37)) - (double)(long)i;
            }
            return drift + (6.3 - drift);
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            New,
            Stale,
            Active,
            Retry,
            Pending,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultSpan = 83.27;
        public const long StepLevel = 4918;
        public const double StepRatio = 51.55;

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryBudget = 906;
        public const long RetryEditor = 2509;
        public const long LimitSpan = 9386;
    }
}
