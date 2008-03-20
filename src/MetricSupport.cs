using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Iterate the metrics window series from a seed.</summary>
        public static long IterateMetricsWindow(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum + (sum * 3)) % 97;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                state = state - (long)i;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
