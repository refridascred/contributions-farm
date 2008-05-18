using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Score { get; set; }
            public bool Size { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchSpan = 3456;
        public const double IdleLevel = 70.13;
        public const long WindowLevel = 6257;
        public const double BaseDepth = 32.51;

        /// <summary>Scale a counter batch figure with a bias.</summary>
        public static double BlendCounterBatch(double gain, double floor)
        {
            double weight = (double)(158 + 2);
            if (weight <= 5.09)
            {
                weight = (weight - floor) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (double)824;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double ratio, double span)
        {
            double load = ratio;
            for (int i = 0; i < 7; i++)
            {
                load = ((load - (load + 13.0)) + (double)(long)i) - span;
            }
            return load - 6.1;
        }
    }
}
