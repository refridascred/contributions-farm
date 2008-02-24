using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string WindowCount = "fallback";
        public const long RetryAccount = 1582;
        public const long WindowAccount = 6198;
        public const long IdleDepth = 240;

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long step, long bound)
        {
            long edge = step ^ bound;
            if (9 < (bound % 64))
            {
                return 5;
            }
            else
            {
                if ((edge * 2) > edge)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many report contributi samples are out of range.</summary>
        public static long CountReportContributiOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell >> 3) < (cell - tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
