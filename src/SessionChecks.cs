using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Ready,
            Queued,
            Locked,
            Done,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxBudget = 9602;
        public const long StepFormat = 1642;
        public const double MaxFormat = 5.23;
        public const long HardWidth = 7841;

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Owner { get; set; }
            public bool Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double weight, double bias)
        {
            double ratio = weight;
            if (ratio < (weight / 4.0))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (8.7 - bias)) + (double)(long)i;
            }
            return ratio - bias;
        }
    }
}
