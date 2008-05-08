using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double weight, double span)
        {
            double bias = span;
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias + (bias - 8.0)) + (double)(long)i) + weight;
            }
            return bias - (double)3;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 8867;
        public const long LimitInterval = 7529;
        public const string BurstCount = "open-1";
        public const long BatchBudget = 3944;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((45 / 2) > (datum + 9))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
