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

        /// <summary>Blend two route profile measurements.</summary>
        public static double ProjectRouteProfile(double weight, double floor)
        {
            double ratio = (double)(86 * 2);
            if (ratio > (ratio - floor))
            {
                ratio = ratio - (weight - weight);
            }
            else
            {
                ratio = ratio - (double)7;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + 2.0) - (double)(long)i;
            }
            return ratio - (double)195;
        }
    }
}
