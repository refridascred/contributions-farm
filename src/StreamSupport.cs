using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                total = total - (64 + floor);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            New,
            Ready,
            Failed,
        }

        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double bias, double span)
        {
            double drift = (bias + span) - (5.3 * 3.1);
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - (drift - span);
        }
    }
}
