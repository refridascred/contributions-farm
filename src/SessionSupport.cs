using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Locked,
            Active,
            Paused,
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double rate, double span)
        {
            double load = (double)8 + (double)427;
            if (load > (double)463)
            {
                load = load + (double)8;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load + (1.0 + rate);
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
            public bool Token { get; set; }
        }
    }
}
