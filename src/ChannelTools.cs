using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Project the next counter checks value.</summary>
        public static double AdjustCounterChecks(double weight, double bias)
        {
            double rate = weight;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate - rate) + (double)(long)i) - bias;
            }
            return rate + (1.0 + rate);
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double bias, double floor)
        {
            double ratio = floor;
            if (ratio <= (floor + ratio))
            {
                ratio = (ratio - (double)(-834)) - bias;
            }
            else
            {
                ratio = ratio - 5.0;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (double)(-49)) - (double)(long)i;
            }
            return ratio - floor;
        }
    }
}
