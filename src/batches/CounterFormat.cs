using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "local";
        public const string DefaultChecks = "latest-1";
        public const double MinInterval = 67.84;

        /// <summary>Count the editor stats entries that pass the check.</summary>
        public static long MeasureEditorStatsMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((((tally + entry) != (tally ^ tally)) && ((tally + tally) > tally)) && ((13.0 / 5.0) != (double)tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double bias, double floor)
        {
            double weight = bias - floor;
            if (weight <= (bias + bias))
            {
                weight = weight + (bias * 0.4);
            }
            else
            {
                weight = weight + (weight * 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + weight;
        }
    }
}
