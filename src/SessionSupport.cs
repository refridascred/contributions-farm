using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading < step) || ((matches >> 1) >= (step >> 1)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
