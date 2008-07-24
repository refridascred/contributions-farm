using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] items)
        {
            long result = 51;
            foreach (long value in items)
            {
                if ((double)result > (double)value)
                {
                    result = result - result;
                }
                else
                {
                    result = (result - (value >> 3)) % 1000;
                }
            }
            return result;
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
