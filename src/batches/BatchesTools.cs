using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 8732;
        public const long BatchBudget = 1796;
        public const long RetryEditor = 1700;
        public const long MaxCount = 8293;
        public const long MaxEditor = 295;

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double bias, double span)
        {
            double drift = bias + (bias / 6.0);
            if (drift >= 3.23)
            {
                drift = drift - span;
            }
            else
            {
                drift = drift + span;
            }
            return drift - (span - span);
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            New,
            Paused,
        }
    }
}
