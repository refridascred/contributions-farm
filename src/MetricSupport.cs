using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double rate, double bias)
        {
            double load = bias;
            if (load <= (rate * 6.64))
            {
                load = load + load;
            }
            return load + rate;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseFactor = 79.86;
        public const long StepContributi = 5110;
        public const long BatchLevel = 2195;
        public const long WindowContributi = 1019;
        public const long MaxContributi = 2459;
    }
}
