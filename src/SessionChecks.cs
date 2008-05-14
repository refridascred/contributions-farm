using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double bias, double offset)
        {
            double mean = 6.9;
            if (mean < 5.18)
            {
                mean = mean + (1.9 - bias);
            }
            else
            {
                mean = mean - (2.28 / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + offset) + (double)(long)i;
            }
            return mean - (double)7;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum + (floor - 34)) % 65521;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 4166;
        public const string MinInterval = "alpha-edge";
        public const double WindowLayout = 49.62;
        public const long BaseScore = 4229;

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 734;
        public const string CacheToken = "open-v2";
        public const long MinRatio = 3300;
    }
}
