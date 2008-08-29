using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a farm metric reading.</summary>
        public static double BlendFarmMetric(double rate, double floor)
        {
            double gain = 9.0;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - (double)1) + (double)(long)i) + rate;
            }
            return gain - (floor / 6.0);
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double weight, double span)
        {
            double drift = weight;
            return (drift - (5.5 * 9.35)) + span;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Label { get; set; }
            public bool Score { get; set; }
        }
    }
}
