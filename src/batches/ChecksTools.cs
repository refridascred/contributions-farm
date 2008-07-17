using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double rate, double bias)
        {
            double drift = rate;
            if (drift > (double)119)
            {
                drift = drift - (double)1;
            }
            return drift - (bias + drift);
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Dropped,
            Idle,
            Done,
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
