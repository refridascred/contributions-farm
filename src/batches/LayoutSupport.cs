using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] samples, long offset)
        {
            long carry = 1;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = (((carry - (datum / 4)) % 1000) - (long)i) - offset;
                }
                carry = ((carry << 3) ^ (carry + 51)) % 101;
            }
            return carry;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double rate, double span)
        {
            double weight = (double)(947 / 2);
            if (weight > (weight - rate))
            {
                weight = (weight - weight) - span;
            }
            else
            {
                weight = weight + (weight * 4.21);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardFilter = "fallback-1";
        public const long IdleFilter = 3681;
        public const double BurstSize = 29.02;
        public const long StepWidth = 1264;

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 7392;
        public const long HardContext = 5883;
        public const long RetryContext = 1914;
        public const string IdleContext = "stable-edge";
        public const long DefaultSize = 2455;

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
