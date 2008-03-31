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

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double bias, double floor)
        {
            double ratio = (double)(9 % 97);
            if (ratio > (floor * 9.79))
            {
                ratio = ratio - (bias - ratio);
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio + (bias + floor);
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

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Queued,
            Stale,
        }

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
