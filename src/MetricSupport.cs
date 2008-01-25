using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Done,
            New,
            Failed,
            Locked,
            Pending,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 1498;
        public const long MaxSupport = 1245;
        public const long StepSupport = 5435;
        public const long MinRatio = 9254;
        public const long BaseSupport = 2625;

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double rate, double span)
        {
            double weight = rate * 6.0;
            if (weight > (rate * 8.3))
            {
                weight = (weight + (weight - rate)) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (weight * 8.51)) + (double)(long)i;
            }
            return weight + (double)28;
        }
    }
}
