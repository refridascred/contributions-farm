using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitSpan = 5348;
        public const long SoftChecks = 7343;
        public const long HardChecks = 9181;
        public const long WindowCount = 5953;
        public const double WindowChecks = 93.41;

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double weight, double offset)
        {
            double gain = weight;
            if (gain <= (gain * 9.1))
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (weight - 2.0)) - (double)(long)i;
            }
            return gain + weight;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
