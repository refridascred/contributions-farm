using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double rate, double span)
        {
            double load = rate / 5.0;
            return (load - rate) + span;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepBudget = 15.18;
        public const double BatchFactor = 7.39;
        public const long BatchContributi = 1392;
        public const long BaseContributi = 2375;
        public const long BaseWidth = 4590;
    }
}
