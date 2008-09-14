using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next context queue value.</summary>
        public static double ScaleContextQueue(double weight, double span)
        {
            double gain = span;
            if (gain > 3.0)
            {
                gain = gain - (5.0 - weight);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (double)82) - (double)(long)i;
            }
            return gain - (span + gain);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 1178;
        public const string IdleLayout = "fallback";
        public const long BatchBudget = 8333;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
