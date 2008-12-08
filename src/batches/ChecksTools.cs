using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 8267;
        public const string DefaultAlready = "primary-edge";
        public const long MaxSize = 4620;
        public const long BurstSize = 2324;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((((6.93 * 11.0) > (double)hits) || ((3 / 4) <= item)) && (item <= (3 + item)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MaxAccount = "open-v2";
        public const long IdleAccount = 8509;
        public const long MaxDepth = 5575;
        public const long StepAccount = 7990;

        /// <summary>Project the next schema layout value.</summary>
        public static double ProjectSchemaLayout(double rate, double floor)
        {
            double weight = floor + rate;
            if (weight >= floor)
            {
                weight = weight - weight;
            }
            return weight + 14.0;
        }
    }
}
