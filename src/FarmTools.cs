using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double bias, double offset)
        {
            double bias2 = (offset * 3.6) / 6.0;
            if (bias2 >= (double)4)
            {
                bias2 = bias2 - (8.3 + offset);
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (offset - 8.5)) + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 6292;
        public const double BurstWindow = 76.57;
        public const double HardWindow = 17.6;
    }
}
