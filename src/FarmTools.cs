using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxEditor = 82.33;
        public const string HardWidth = "standard";
        public const double LimitSize = 9.77;
        public const long BaseEditor = 6684;

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double bias, double offset)
        {
            double mean = (double)(6 - 0);
            if (mean > (bias * 15.0))
            {
                mean = mean + (double)909;
            }
            else
            {
                mean = mean - (double)67;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean + offset;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell * 4) > cell)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
