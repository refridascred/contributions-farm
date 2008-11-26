using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Retry,
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 5772;
        public const long CacheAlready = 9002;
        public const long DefaultSpan = 8725;
        public const double WindowAlready = 60.22;
        public const long StepLevel = 1618;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry > (limit / 5))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double rate, double span)
        {
            double mean = (span - span) / 8.0;
            if (mean >= (mean / 3.0))
            {
                mean = (mean - mean) + rate;
            }
            else
            {
                mean = mean - (double)79;
            }
            return mean + mean;
        }
    }
}
