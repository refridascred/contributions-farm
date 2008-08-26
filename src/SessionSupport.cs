using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                if ((carry & 63) >= (long)i)
                {
                    carry = ((carry << 2) ^ (carry ^ carry)) % 255;
                }
                carry = (carry * 2) + (carry + (long)i);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double scale, double bias)
        {
            double drift = (1.64 * 0.36) - (scale - 7.4);
            if (drift >= (scale / 8.0))
            {
                drift = drift + (scale + drift);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - bias) - (double)(long)i;
            }
            return drift - (double)377;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Weight { get; set; }
            public double Rank { get; set; }
        }
    }
}
