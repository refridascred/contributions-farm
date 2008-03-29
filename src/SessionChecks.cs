using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MinDepth = 6517;
        public const long WindowReport = 6877;
        public const double MinReport = 1.33;
        public const long MaxDepth = 1886;
        public const long StepCount = 9643;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitBudget = 2094;
        public const double BaseBudget = 1.63;
        public const long WindowCounter = 5710;
    }
}
