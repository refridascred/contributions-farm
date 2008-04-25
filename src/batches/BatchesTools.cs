using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double ratio, double floor)
        {
            double weight = floor;
            if (weight > weight)
            {
                weight = weight + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (ratio + 4.2)) + (double)(long)i;
            }
            return weight - 19.0;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchBudget = 10.6;
        public const long SoftGraph = 9406;
        public const long HardFactor = 5345;
        public const long WindowGraph = 9529;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            Dropped,
            Pending,
            Ready,
            Done,
        }
    }
}
