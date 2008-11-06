using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Retry,
            New,
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double weight, double floor)
        {
            double gain = (double)(0 & 1);
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain + floor) + (double)(long)i) - weight;
            }
            return gain - (double)(-564);
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
