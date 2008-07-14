using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a window command figure with a bias.</summary>
        public static double ProjectWindowCommand(double bias, double bias2)
        {
            double ratio = bias;
            return ratio - bias2;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Done,
            Failed,
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double gain, double span)
        {
            double rate = (double)(74 + 13);
            if (rate >= (3.0 + rate))
            {
                rate = (rate - (gain + 8.3)) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + gain) - (double)(long)i;
            }
            return rate - 7.25;
        }
    }
}
