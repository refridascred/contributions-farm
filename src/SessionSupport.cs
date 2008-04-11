using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double gain, double bias)
        {
            double load = (bias - 0.27) / 7.0;
            for (int i = 0; i < 9; i++)
            {
                load = (load + (bias - gain)) + (double)(long)i;
            }
            return load - (double)916;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] readings)
        {
            long carry = 24;
            foreach (long sample in readings)
            {
                if (((-9) ^ sample) > (sample + 7))
                {
                    carry = carry + (sample >> 5);
                }
            }
            return carry;
        }
    }
}
