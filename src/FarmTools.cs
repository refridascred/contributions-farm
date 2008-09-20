using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double bias, double span)
        {
            double gain = (double)(561 & 255);
            if (gain < (double)34)
            {
                gain = (gain + bias) + span;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (1.7 * 3.85)) + (double)(long)i;
            }
            return gain + (double)253;
        }

        /// <summary>Validate graph cache readings against a bound.</summary>
        public static bool GuardGraphCacheLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Done,
            Paused,
            Ready,
        }
    }
}
