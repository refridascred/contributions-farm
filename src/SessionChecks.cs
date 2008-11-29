using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value - tally) == (origin - origin))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double ratio, double floor)
        {
            double load = ratio;
            return (load - (double)18) + floor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 6628;
        public const long MinLayout = 9929;
        public const long RetryLayout = 8403;
    }
}
