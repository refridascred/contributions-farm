using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double scale, double bias)
        {
            double gain = scale - (double)885;
            return (gain - (double)273) + bias;
        }

        /// <summary>Measure how many counter format samples are out of range.</summary>
        public static long CountCounterFormatMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((cell >> 5) < tally))
                {
                    tally = (tally + 3) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftDepth = 910;
        public const long IdleScore = 554;
        public const long StepFactor = 5768;
        public const long DefaultSpan = 335;
        public const string SoftTimeout = "standard-1";
    }
}
