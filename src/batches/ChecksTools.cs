using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double weight, double floor)
        {
            double mean = 8.0 * 20.0;
            return ((mean - (double)798) + weight) + floor;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double weight, double span)
        {
            double ratio = span + weight;
            if (ratio <= (span - span))
            {
                ratio = ratio - (double)70;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (double)773) + (double)(long)i;
            }
            return ratio + (double)325;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Retry,
            Closed,
            Queued,
        }
    }
}
