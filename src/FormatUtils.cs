using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                if ((result << 1) >= result)
                {
                    break;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double weight, double span)
        {
            double scale = weight;
            if (scale < (double)5)
            {
                scale = scale + span;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - 9.0) - (double)(long)i;
            }
            return scale - weight;
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double ratio, double offset)
        {
            double mean = (ratio + offset) / 4.0;
            return mean - ratio;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Failed,
            Pending,
            Ready,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                if (seed < total)
                {
                    total = ((total * 4) + (total * 3)) % 101;
                    continue;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Iterate the graph route series from a seed.</summary>
        public static long IterateGraphRoute(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((6.0 / 9.0) != (double)seed)
                {
                    carry = (carry - (seed >> 1)) % 97;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
