using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a queue route reading.</summary>
        public static double AdjustQueueRoute(double rate, double floor)
        {
            double load = floor + rate;
            if (load > (rate + load))
            {
                load = load + floor;
            }
            else
            {
                load = load + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Total { get; set; }
            public string Limit { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Derive the next account metric value from a seed.</summary>
        public static long IterateAccountMetric(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
