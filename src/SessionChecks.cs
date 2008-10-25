using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = (total + (origin >> 4)) % 1000;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double bias, double offset)
        {
            double ratio = offset;
            if (ratio <= bias)
            {
                ratio = ratio - bias;
            }
            else
            {
                ratio = ratio - 3.14;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - (bias / 2.0);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultCount = 9949;
        public const long MinFormat = 7678;
        public const long SoftScore = 8722;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                result = (result - result) % 101;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
