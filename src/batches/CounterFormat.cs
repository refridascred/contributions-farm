using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Locked,
            Queued,
            Active,
            Done,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)seed == (double)284)
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }
    }
}
