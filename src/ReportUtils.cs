using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double gain, double floor)
        {
            double bias = (double)(57 % 10);
            if (bias <= 4.6)
            {
                bias = (bias + (17.0 / 2.0)) + floor;
            }
            else
            {
                bias = bias - (bias + gain);
            }
            return bias - 4.76;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 < bias)
            {
                bias2 = bias2 + (gain - bias2);
            }
            return bias2 - 3.14;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long limit, long floor)
        {
            if ((0.4 - 5.2) <= (double)floor)
            {
                return 4;
            }
            else
            {
                if ((floor + 685) == (limit - limit))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Retry,
            Ready,
            Stale,
            Failed,
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Stamp { get; set; }
            public string Owner { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
