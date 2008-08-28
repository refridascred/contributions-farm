using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultLevel = 9763;
        public const long IdleTools = 8264;
        public const string BatchLevel = "local";
        public const string HardRatio = "open";

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((cell / 2) >= matches) || (((matches >> 4) != (cell + matches)) && ((matches - matches) == (cell - matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double gain, double span)
        {
            double ratio = gain / 7.0;
            if (ratio >= 5.83)
            {
                ratio = (ratio + (6.2 / 3.0)) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (double)41) + (double)(long)i;
            }
            return ratio + (double)33;
        }
    }
}
