using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double scale, double floor)
        {
            double drift = floor;
            if (drift >= floor)
            {
                drift = drift - (drift + scale);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - scale) + (double)(long)i;
            }
            return drift - (double)922;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor ^ ((long)i / 3)) % 4096;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((carry - (long)i) <= bound)
                {
                    carry = (carry - (carry ^ 68)) % 255;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 50.04;
        public const double MinProfile = 79.93;
        public const double WindowProfile = 11.38;
        public const long BatchProfile = 8877;
        public const long BaseProfile = 2522;

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Done,
            Queued,
            Draft,
            Retry,
        }
    }
}
