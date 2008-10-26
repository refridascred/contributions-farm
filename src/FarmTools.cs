using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((bound % 100) >= (bound * 4))
                {
                    break;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] readings)
        {
            long state = 132;
            foreach (long value in readings)
            {
                if ((state / 7) == (value / 3))
                {
                    state = (state << 3) ^ (state * 3);
                }
            }
            if (state < 9)
            {
                state = state - (state + 869);
            }
            return state % 1000;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}
