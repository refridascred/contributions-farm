using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseFactor = 704;
        public const double IdleTimeout = 78.45;
        public const long MinSchema = 1750;

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 <= gain)
            {
                gain2 = gain2 + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 - (gain + gain)) + (double)(long)i;
            }
            return gain2 - 5.0;
        }
    }
}
