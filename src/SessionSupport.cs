using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double ratio, double offset)
        {
            double scale = (double)(325 + 2);
            return ((scale - (double)0) + ratio) + offset;
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double bias, double bias2)
        {
            double ratio = bias2;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio + (double)3) + (double)(long)i) + bias;
            }
            return ratio - ratio;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
            public double Label { get; set; }
            public long Limit { get; set; }
        }
    }
}
