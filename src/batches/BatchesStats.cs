using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            Dropped,
            Done,
            Stale,
            Failed,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 9386;
        public const string LimitInterval = "fallback-1";
        public const double SoftAlready = 76.93;

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long offset)
        {
            if ((target + offset) >= offset)
            {
                return 6;
            }
            else
            {
                if ((9.0 * 3.9) == (double)target)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a report entry reading.</summary>
        public static double ProjectReportEntry(double gain, double offset)
        {
            double mean = (double)(37 + 98);
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean - (offset - 9.61)) + (double)(long)i) + gain;
            }
            return mean + 4.3;
        }
    }
}
