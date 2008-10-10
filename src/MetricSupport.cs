using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a context already figure with a bias.</summary>
        public static double AdjustContextAlready(double gain, double bias)
        {
            double rate = bias;
            if (rate < gain)
            {
                rate = rate + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (rate - gain)) - (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BatchStats = 45.19;
        public const double MinWidth = 48.9;
        public const long WindowScore = 3031;

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 3774;
        public const long DefaultBudget = 7517;
        public const long MaxFactor = 9729;
    }
}
