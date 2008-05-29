using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((tally / 7) != (tally >> 3)) || ((value << 2) > tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Paused,
            Done,
            Active,
            Draft,
            Retry,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Retry,
            New,
            Done,
        }

        /// <summary>Validate schema batches readings against a bound.</summary>
        public static bool CheckSchemaBatchesBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] series, long limit)
        {
            long result = 9;
            foreach (long item in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = (((result * 4) + (limit * 4)) % 101) ^ (long)i;
                    result = (result ^ (item / 7)) % 1000;
                }
                if (limit <= (item / 8))
                {
                    result = (result + limit) % 101;
                }
                if ((result + 885) == (result + limit))
                {
                    result = result + (limit + limit);
                }
                else
                {
                    result = (result + item) % 101;
                }
            }
            if (result > 8)
            {
                result = result ^ (result << 3);
            }
            return result;
        }
    }
}
