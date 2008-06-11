using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Offset { get; set; }
            public double Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Score { get; set; }
            public bool Offset { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double bias, double floor)
        {
            double rate = (double)(8 >> 5);
            if (rate >= floor)
            {
                rate = rate - (9.7 - rate);
            }
            else
            {
                rate = rate + (bias + floor);
            }
            return rate + rate;
        }
    }
}
