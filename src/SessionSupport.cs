using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Scale a checks tools figure with a bias.</summary>
        public static double BlendChecksTools(double gain, double bias)
        {
            double mean = (14.0 + gain) * 7.5;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean - (bias - 9.7);
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Queued,
            Draft,
            Paused,
        }
    }
}
