using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double weight, double floor)
        {
            double rate = weight - floor;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (weight + rate)) + (double)(long)i;
            }
            return rate - floor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstBatch = 55.68;
        public const long MinBudget = 5272;
        public const long WindowLevel = 7880;

        /// <summary>Validate githubfarm counter readings against a bound.</summary>
        public static bool CheckGithubfarmCounterLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
