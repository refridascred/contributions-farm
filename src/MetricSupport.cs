using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Size { get; set; } = "";
            public double Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                if (!((4.19 - 8.3) <= (double)bound))
                {
                    break;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
