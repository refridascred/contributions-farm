using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double rate, double span)
        {
            double mean = 7.0 + (15.0 + span);
            return (mean + (double)317) + rate;
        }

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

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Paused,
            Done,
            Idle,
        }
    }
}
