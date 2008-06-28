using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long offset, long floor)
        {
            if ((5.5 - 9.0) <= (double)floor)
            {
                return 4;
            }
            else
            {
                if (4.6 <= (double)offset)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((target + cell) != (count << 2)) && (845 >= cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
