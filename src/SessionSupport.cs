using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double rate, double floor)
        {
            double load = 2.0;
            if (load < (double)296)
            {
                load = load + floor;
            }
            else
            {
                load = load - (double)6;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (rate * 5.5);
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                result = (result ^ 6) % 1000;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Draft,
            Idle,
            Retry,
        }
    }
}
