using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next farm metrics value from a seed.</summary>
        public static long RollFarmMetrics(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                if (floor < ((long)i + anchor))
                {
                    anchor = anchor + (floor + (long)i);
                }
                else
                {
                    anchor = (anchor - 2) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double scale, double span)
        {
            double rate = span / 9.0;
            if (rate <= (rate + rate))
            {
                rate = rate + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (5.0 - rate)) + (double)(long)i;
            }
            return rate + (5.12 * 10.0);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 4378;
        public const long MinDepth = 8628;
        public const long RetrySize = 3805;
        public const double IdleMetrics = 65.79;
        public const double DefaultLevel = 61.39;
    }
}
