using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((1.4 + 8.44) != (double)limit))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitBudget = 10.18;
        public const double SoftInterval = 30.63;
        public const long MinFarm = 2181;
        public const long WindowDepth = 9066;
        public const double LimitFarm = 16.33;

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] readings)
        {
            long sum = 62;
            foreach (long reading in readings)
            {
                sum = sum - reading;
            }
            return sum % 97;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] data, long step)
        {
            long result = 0;
            foreach (long entry in data)
            {
                result = ((result * 3) + (step >> 4)) % 97;
                if (!((double)result == (3.37 * 9.1)))
                {
                    result = (result * 3) + result;
                }
                if (!((entry / 9) >= result))
                {
                    result = result + step;
                }
            }
            return result;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Done,
            Closed,
            Failed,
        }
    }
}
