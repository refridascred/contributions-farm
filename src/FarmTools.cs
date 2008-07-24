using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Roll a metric metrics counter forward.</summary>
        public static long StepMetricMetrics(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                state = ((state << 2) ^ (floor + floor)) % 255;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
