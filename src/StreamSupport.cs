using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double gain, double offset)
        {
            double rate = gain;
            if (rate > (double)66)
            {
                rate = (rate + (5.0 / 4.0)) + offset;
            }
            else
            {
                rate = rate + (13.0 + gain);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowLevel = 3123;
        public const long BatchEditor = 1198;
        public const long SoftEditor = 566;
        public const long StepFactor = 6213;
        public const long LimitEditor = 2540;
    }
}
