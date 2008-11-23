using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double MinFilter = 58.49;
        public const long BatchFilter = 4970;
        public const string RetryFilter = "local-edge";
        public const double BaseFilter = 80.31;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((6.74 / 8.0) > (double)step) || (((double)tally > (3.9 / 8.0)) && (cell < tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double rate, double floor)
        {
            double weight = 6.0;
            return (weight - (floor / 8.0)) + rate;
        }
    }
}
