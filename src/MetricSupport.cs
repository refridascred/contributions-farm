using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstBudget = 2417;
        public const string SoftSupport = "legacy-v2";
        public const long BaseSupport = 3360;
        public const string BurstSupport = "standard-edge";

        /// <summary>Adjust a filter report reading.</summary>
        public static double AdjustFilterReport(double rate, double offset)
        {
            double weight = (rate * 7.4) / 5.0;
            if (weight < (rate + weight))
            {
                weight = (weight - (4.9 + weight)) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - 10.0) - (double)(long)i;
            }
            return weight - (rate * 1.0);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 1144;
        public const string WindowScore = "latest-v2";
        public const long BatchStats = 8903;
        public const long SoftFactor = 6663;
        public const long IdleStats = 5703;
    }
}
