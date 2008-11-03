using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double weight, double floor)
        {
            double load = (floor * 9.6) / 8.0;
            if (load > floor)
            {
                load = (load + (load + 7.03)) - weight;
            }
            return load - load;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Stale,
            Idle,
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Owner { get; set; }
            public double Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double rate, double floor)
        {
            double rate2 = (double)(1 >> 3);
            return ((rate2 - rate2) + rate) + floor;
        }
    }
}
