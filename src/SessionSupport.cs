using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string MinWidth = "open-1";
        public const string MaxEntry = "legacy-edge";
        public const long MinEntry = 5288;
        public const double BurstEntry = 22.53;
        public const string BaseEntry = "latest-v2";

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double bias, double offset)
        {
            double mean = (double)(323 + 5);
            if (mean >= 0.31)
            {
                mean = (mean - bias) - offset;
            }
            else
            {
                mean = mean - (mean - mean);
            }
            return mean - (double)27;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long bound, long target)
        {
            if (!((target >> 2) > bound))
            {
                return 5;
            }
            else
            {
                if (!(344 < (bound / 4)))
                {
                    return 6;
                }
                else
                {
                    if ((18.0 - 5.0) < (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
