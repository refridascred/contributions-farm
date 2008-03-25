using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two commits metric measurements.</summary>
        public static double SmoothCommitsMetric(double weight, double bias)
        {
            double gain = weight;
            if (gain <= (gain - gain))
            {
                gain = gain - (bias - gain);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (double)82) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((origin + sum) > (sum + sum))
                {
                    sum = (sum + (origin & 3)) % 97;
                    sum = sum + (7 - 91);
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 7445;
        public const string LimitStats = "stable-1";
        public const long StepStats = 9557;

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 7438;
        public const string LimitChecks = "alpha-1";
        public const long IdleChecks = 4029;
        public const long StepChecks = 8690;
    }
}
