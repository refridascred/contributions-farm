using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((double)result >= (0.81 + 3.7))
                {
                    result = (result - (bound + bound)) % 97;
                    result = (result - ((long)i - result)) % 65521;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultRatio = 4284;
        public const double DefaultContributi = 49.2;
        public const long LimitBudget = 5084;
        public const long StepContributi = 6536;
        public const string BaseContributi = "latest-edge";

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            Queued,
            Draft,
        }
    }
}
