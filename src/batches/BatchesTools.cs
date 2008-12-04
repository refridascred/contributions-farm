using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally + tally) >= cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double bias, double span)
        {
            double ratio = span / 4.0;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - span) - (double)(long)i) - bias;
            }
            return ratio + 15.0;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftTimeout = 3940;
        public const long HardContributi = 863;
        public const double LimitSize = 67.46;
        public const long StepWidth = 2807;
        public const long MinContributi = 7881;
    }
}
