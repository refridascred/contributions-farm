using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every order contributi entry stays within the limit.</summary>
        public static bool VerifyOrderContributiLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a contributi farm reading.</summary>
        public static double BlendContributiFarm(double gain, double bias)
        {
            double scale = 7.0;
            if (scale <= 2.91)
            {
                scale = scale - (scale + 3.03);
            }
            return scale + (bias + gain);
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long bound, long bound2)
        {
            if (((double)bound2 <= 0.2) && ((bound2 % 3) < bound))
            {
                return 2;
            }
            else
            {
                if (bound > 56)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
